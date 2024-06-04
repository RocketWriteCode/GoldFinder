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
using GoldFinder.Saving;

namespace GoldFinder
{
    public partial class MainWindow : Form
    {
        ListViewItem currentSelection;

        public MainWindow()
        {
            InitializeComponent();

            LocationList.View = View.List;
            LocationList.LabelEdit = false;

            UpdateDisplay();
        }

        void UpdateDisplay()
        {
            LocationList.Clear();

            foreach(Location location in LocationManager.locations)
            {
                LocationList.Items.Add(location.name);
            }
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            bool done = false;
            string nameRoot = "New Location";
            int ModifierNumber = 0;
            string newName = "";

            while (!done)
            {
                done = true;
                newName = $"{nameRoot} {ModifierNumber}";
                foreach (ListViewItem location in LocationList.Items)
                {
                    if (newName != location.Text) continue;
                    done = false;
                }
                ModifierNumber++;
            }

            LocationManager.AddLocation(newName);
            UpdateDisplay();
            currentSelection = LocationList.FindItemWithText("new location");
            LocationName.Text = currentSelection.Text;
        }

        private void RemoveLocationButton_Click(object sender, EventArgs e)
        {
            if (LocationList.SelectedItems.Count <= 0) return;
            LocationManager.DeleteLocation(LocationList.SelectedItems[0].Text);
            UpdateDisplay();
        }

        private void LocationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocationList.SelectedItems.Count <= 0) return;
            LocationName.Text = LocationList.SelectedItems[0].Text;
            currentSelection = LocationList.SelectedItems[0];
        }

        private void LocationName_TextChanged(object sender, EventArgs e)
        {
            if (currentSelection == null) return;

            if (!LocationManager.GetLocationByName(currentSelection.Text, out Location location)) return;

            location.name = LocationName.Text;
            currentSelection.Text = LocationName.Text;
        }

        private void EditSublocationsButton_Click(object sender, EventArgs e)
        {
            if (currentSelection == null) return;

            SubLocationsMenu subLocations = new SubLocationsMenu(LocationManager.GetLocationByName(currentSelection.Text));
            subLocations.Show();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadManager.LoadFromFile();
            UpdateDisplay();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveManager.SaveToFile();
        }

        private void ResourceSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourceSettingsWindow resourceSettings = new ResourceSettingsWindow();
            resourceSettings.Show();
        }
    }
}
