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
        ListViewItem currentSelection;

        public SubLocationsMenu(Location inLocation)
        {
            InitializeComponent();

            LocationName.Text = inLocation.name;

            SubLocationList.View = View.List;
            SubLocationList.LabelEdit = false;
            RecipeListView.View = View.List;
            RecipeListView.LabelEdit = false;
            currentLocation = inLocation;
            UpdateDisplay();
        }

        private void AddSublocationButton_Click(object sender, EventArgs e)
        {
            currentLocation.AddSublocation("New Sublocation");
            UpdateDisplay();
            SetSelection(SubLocationList.FindItemWithText("New Sublocation"));
            SublocationNameField.Text = currentSelection.Text;
        }

        private void RemoveSublocationButton_Click(object sender, EventArgs e)
        {
            if(SubLocationList.SelectedItems.Count <= 0)
            {
                return;
            }

            currentLocation.RemoveSublocation(SubLocationList.SelectedItems[0].Text);
            UpdateDisplay();
        }

        void UpdateDisplay()
        {
            SubLocationList.Clear();
            RecipeListView.Clear();

            foreach (Sublocation subLocation in currentLocation.subLocations)
            {
                SubLocationList.Items.Add(subLocation.name);
            }


            SetSelection(SubLocationList.Items[0]);


            if(currentlySelectedSublocation != null)
            {
                foreach(Recipe recipe in currentlySelectedSublocation.recipes)
                {
                    RecipeListView.Items.Add(recipe.name);
                }
            }
        }

        private void SublocationNameField_TextChanged(object sender, EventArgs e)
        {
            if (currentSelection == null)
            {
                return;
            }

            if (currentLocation.GetSublocationByName(currentSelection.Text, out Sublocation subLocation))
            {
                subLocation.name = SublocationNameField.Text;
                currentSelection.Text = SublocationNameField.Text;
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
            UpdateDisplay();
        }

        private void SetSelection(ListView.SelectedListViewItemCollection items)
        {
            if (items.Count <= 0) return;
            currentSelection = items[0];
            currentlySelectedSublocation = currentLocation.GetSublocationByName(currentSelection.Text);
        }

        private void SetSelection(ListViewItem item)
        {
            currentSelection = item;
            currentlySelectedSublocation = currentLocation.GetSublocationByName(currentSelection.Text);
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            currentlySelectedSublocation.AddRecipe(new Recipe("new recipe"));
            UpdateDisplay();
        }
    }
}
