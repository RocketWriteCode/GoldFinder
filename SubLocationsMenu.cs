using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldFinder.EntitySystem;
using GoldFinder.Resources;

namespace GoldFinder
{
    public partial class SubLocationsMenu : Form
    {
        readonly Location currentLocation;
        Sublocation currentlySelectedSublocation;
        ListViewItem currentSublocationSelection;

        ListViewItem currentRecipeSelection;
        Recipe currentRecipe;

        ListViewItem currentIngredientSelection;
        Resource currentIngredient;

        string currentResourceSelection = "";

        public SubLocationsMenu(Location inLocation)
        {
            InitializeComponent();

            LocationName.Text = inLocation.name;

            SubLocationList.View = View.List;
            SubLocationList.LabelEdit = false;
            RecipeListView.View = View.List;
            RecipeListView.LabelEdit = false;
            IngredientListView.View = View.List;
            IngredientListView.LabelEdit = false;
            OutputListView.View = View.List;
            OutputListView.LabelEdit = false;
            currentLocation = inLocation;
            UpdateDisplay();
        }

        private void AddSublocationButton_Click(object sender, EventArgs e)
        {
            bool done = false;
            string nameRoot = "New Sublocation";
            int ModifierNumber = 0;
            string newName = "";

            while (!done)
            {
                done = true;
                newName = $"{nameRoot} {ModifierNumber}";
                foreach (ListViewItem sublocation in SubLocationList.Items)
                {
                    if (newName == sublocation.Text)
                    {
                        done = false;
                    }
                }
                ModifierNumber++;
            }

            currentLocation.AddSublocation(newName);
            UpdateDisplay();
            SetSelection(SubLocationList.FindItemWithText("New Sublocation"));
            SublocationNameField.Text = currentSublocationSelection.Text;
        }

        private void RemoveSublocationButton_Click(object sender, EventArgs e)
        {
            if(SubLocationList.SelectedItems.Count <= 0)
            {
                return;
            }

            currentLocation.RemoveSublocation(SubLocationList.SelectedItems[0].Text);
            currentlySelectedSublocation = null;
            SublocationNameField.Text = "";
            RecipeNameBox.Text = "";
            currentRecipe = null;
            UpdateDisplay();
        }

        void UpdateDisplay()
        {
            SubLocationList.Clear();
            RecipeListView.Clear();
            IngredientListView.Clear();
            OutputListView.Clear();

            foreach (Sublocation subLocation in currentLocation.subLocations)
            {
                SubLocationList.Items.Add(subLocation.name);
            }

            if(SubLocationList.Items.Count > 0)
            {
                SetSelection(SubLocationList.Items[0]);
            }

            if(currentlySelectedSublocation != null)
            {
                foreach(Recipe recipe in currentlySelectedSublocation.recipes)
                {
                    RecipeListView.Items.Add(recipe.name);
                }
            }

            if(currentRecipe != null)
            {                
                foreach(Resource ingredient in currentRecipe.ingredients)
                {
                    IngredientListView.Items.Add(ingredient.name);
                }

                foreach(Resource output in currentRecipe.output)
                {
                    Console.WriteLine(output.name);
                    OutputListView.Items.Add(output.name);
                }
            }

            ResourceSelector.Items.Clear();
            List<Resource> globalResources = ResourceManager.GetAllGlobalResources();
            foreach(Resource resource in globalResources)
            {
                ResourceSelector.Items.Add(resource.name);
            }
            ResourceSelector.SelectedItem = currentResourceSelection;
        }

        private void SublocationNameField_TextChanged(object sender, EventArgs e)
        {
            if (currentSublocationSelection == null)
            {
                return;
            }

            if (currentLocation.GetSublocationByName(currentSublocationSelection.Text, out Sublocation subLocation))
            {
                subLocation.name = SublocationNameField.Text;
                currentSublocationSelection.Text = SublocationNameField.Text;
            }

            UpdateDisplay();
        }

        private void SubLocationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SubLocationList.SelectedItems.Count > 0)
            {
                SublocationNameField.Text = SubLocationList.SelectedItems[0].Text;
                SetSelection(SubLocationList.SelectedItems);
            }
        }

        private void SetSelection(ListView.SelectedListViewItemCollection items)
        {
            if (items.Count <= 0) return;
            currentSublocationSelection = items[0];
            currentlySelectedSublocation = currentLocation.GetSublocationByName(currentSublocationSelection.Text);
        }

        private void SetRecipeSelection(ListView.SelectedListViewItemCollection items)
        {
            if (items.Count <= 0) return;
            currentRecipeSelection = items[0];
            currentRecipe = currentlySelectedSublocation.GetRecipeByName(currentRecipeSelection.Text);
        }

        private void SetSelection(ListViewItem item)
        {
            if (item == null) return;
            currentSublocationSelection = item;
            currentlySelectedSublocation = currentLocation.GetSublocationByName(currentSublocationSelection.Text);
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            currentlySelectedSublocation.AddRecipe(new Recipe("new recipe"));
            UpdateDisplay();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            if (RecipeListView.SelectedItems.Count <= 0) return;

            string recipeName = RecipeListView.SelectedItems[0].Text;
            currentlySelectedSublocation.DeleteRecipe(recipeName);
            currentRecipe = null;

            IngredientAmountBox.Text = "";
            RecipeNameBox.Text = "";
            IngredientListView.Clear();
            OutputListView.Clear();

            UpdateDisplay();
        }

        private void RecipeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecipeListView.SelectedItems.Count > 0)
            {
                SetRecipeSelection(RecipeListView.SelectedItems);
                RecipeNameBox.Text = RecipeListView.SelectedItems[0].Text;
            }
        }

        private void RecipeNameBox_TextChanged(object sender, EventArgs e)
        {
            if (currentRecipeSelection == null) return;
            if (currentlySelectedSublocation == null) return;

            foreach(Recipe recipe in currentlySelectedSublocation.recipes)
            {
                if(recipe.name == currentRecipeSelection.Text)
                {
                    recipe.name = RecipeNameBox.Text;
                }
            }
            currentRecipeSelection.Text = RecipeNameBox.Text;

            UpdateDisplay();
        }

        private void AddInputButton_Click(object sender, EventArgs e)
        {
            Resource newIngredient = new Resource("New Ingredient");
            currentRecipe.ingredients.Add(newIngredient);
            UpdateDisplay();
        }

        private void DeleteInputButton_Click(object sender, EventArgs e)
        {
            if (IngredientListView.SelectedItems.Count <= 0) return;

            string resourceName = IngredientListView.SelectedItems[0].Text;
            currentRecipe.DeleteIngredientByName(resourceName);
            UpdateDisplay();
        }

        private void AddOutputButton_Click(object sender, EventArgs e)
        {
            Resource newOutput = new Resource("New output");
            currentRecipe.output.Add(newOutput);
            UpdateDisplay();
        }

        private void DeleteOutputButton_Click(object sender, EventArgs e)
        {
            if (OutputListView.SelectedItems.Count <= 0) return;

            string outputName = OutputListView.SelectedItems[0].Text;
            currentRecipe.DeleteOutputByName(outputName);
            UpdateDisplay();
        }

        private void IngredientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IngredientListView.SelectedItems.Count <= 0) return;

            currentIngredientSelection = IngredientListView.SelectedItems[0];
            currentIngredient = currentRecipe.GetIngredientByName(currentIngredientSelection.Text);
            ResourceSelector.SelectedItem = currentIngredient.name;
        }

        private void ResourceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentResourceSelection == ResourceSelector.SelectedItem.ToString()) return;

            currentRecipe.ReplaceIngredient(currentResourceSelection, ResourceSelector.Text);
            currentResourceSelection = ResourceSelector.Text;
            UpdateDisplay();
        }
    }
}
