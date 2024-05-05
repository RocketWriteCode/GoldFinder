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
    public partial class SubLocationsMenu : Form
    {
        Location currentLocation;

        public SubLocationsMenu(Location inLocation)
        {
            InitializeComponent();

            LocationName.Text = inLocation.name;

            SubLocationList.View = View.List;
            SubLocationList.MultiSelect = false;
            SubLocationList.LabelEdit = false;

            currentLocation = inLocation;
        }

        private void AddSublocationButton_Click(object sender, EventArgs e)
        {
            currentLocation.AddSublocation("New Sublocation");
            UpdateDisplay();
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

            foreach (SubLocation subLocation in currentLocation.subLocations)
            {
                SubLocationList.Items.Add(subLocation.name);
            }
        }
    }
}
