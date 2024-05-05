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

namespace GoldFinder
{
    public partial class Form1 : Form
    {
        readonly LocationManager locationManager;
        ListViewItem currentSelection;

        public Form1()
        {
            InitializeComponent();
            locationManager = new LocationManager();

            LocationList.View = View.List;
            LocationList.LabelEdit = false;

            UpdateDisplay();
        }

        void UpdateDisplay()
        {
            LocationList.Clear();

            foreach(Location location in locationManager.locations)
            {
                LocationList.Items.Add(location.name);
            }
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            locationManager.AddLocation("new location");
            UpdateDisplay();
            currentSelection = LocationList.FindItemWithText("new location");
            LocationName.Text = currentSelection.Text;
        }

        private void RemoveLocationButton_Click(object sender, EventArgs e)
        {
            if(LocationList.SelectedItems.Count <= 0)
            {
                return;
            }

            locationManager.DeleteLocation(LocationList.SelectedItems[0].Text);
            UpdateDisplay();
        }

        private void LocationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LocationList.SelectedItems.Count > 0)
            {
                LocationName.Text = LocationList.SelectedItems[0].Text;
                currentSelection = LocationList.SelectedItems[0];
            }
        }

        private void LocationName_TextChanged(object sender, EventArgs e)
        {
            if(currentSelection == null)
            {
                return;
            }

            if(locationManager.GetLocationByName(currentSelection.Text, out Location location))
            {
                location.name = LocationName.Text;
                currentSelection.Text = LocationName.Text;
            }
        }

        private void EditSublocationsButton_Click(object sender, EventArgs e)
        {
            if(currentSelection != null)
            {
                SubLocationsMenu subLocations = new SubLocationsMenu(locationManager.GetLocationByName(currentSelection.Text));
                subLocations.Show();
            }
        }
    }
}
