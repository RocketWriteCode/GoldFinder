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
        readonly Location currentLocation;
        ListViewItem currentSelection;

        public SubLocationsMenu(Location inLocation)
        {
            InitializeComponent();

            LocationName.Text = inLocation.name;

            SubLocationList.View = View.List;
            SubLocationList.LabelEdit = false;
            currentLocation = inLocation;
        }

        private void AddSublocationButton_Click(object sender, EventArgs e)
        {
            currentLocation.AddSublocation("New Sublocation");
            UpdateDisplay();
            currentSelection = SubLocationList.FindItemWithText("New Sublocation");
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

            foreach (SubLocation subLocation in currentLocation.subLocations)
            {
                SubLocationList.Items.Add(subLocation.name);
            }
        }

        private void SublocationNameField_TextChanged(object sender, EventArgs e)
        {
            if (currentSelection == null)
            {
                return;
            }

            if (currentLocation.GetSublocationByName(currentSelection.Text, out SubLocation subLocation))
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
                currentSelection = SubLocationList.SelectedItems[0];
            }
        }
    }
}
