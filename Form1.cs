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
        LocationManager locationManager;

        public Form1()
        {
            InitializeComponent();
            locationManager = new LocationManager();

            LocationList.View = View.List;
            LocationList.LabelEdit = false;
            LocationList.MultiSelect = false;

            UpdateDisplay();
        }

        void UpdateDisplay()
        {
            LocationList.Clear();

            foreach(Entity entity in locationManager.locations)
            {
                if (entity.GetType() == typeof(Location))
                {
                    LocationList.Items.Add(entity.name);
                }
            }
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            locationManager.AddLocation("new location");
            UpdateDisplay();
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
            }
        }

        private void LocationName_TextChanged(object sender, EventArgs e)
        {
            if(locationManager.GetLocationByName(LocationList.SelectedItems[0].Text, out Location location))
            {
                location.name = LocationName.Text;
                LocationList.SelectedItems[0].Text = LocationName.Text;
            }
        }

        private void EditSublocationsButton_Click(object sender, EventArgs e)
        {
            if(LocationList.SelectedItems.Count > 0)
            {
                SubLocationsMenu subLocations = new SubLocationsMenu(locationManager.GetLocationByName(LocationList.SelectedItems[0].Text));
                subLocations.Show();
            }
        }
    }
}
