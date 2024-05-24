using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldFinder.Resources;

namespace GoldFinder
{
    public partial class ResourceSettingsWindow : Form
    {
        public ResourceSettingsWindow()
        {
            InitializeComponent();
        }

        private void AddResourceButton_Click(object sender, EventArgs e)
        {
            bool done = false;
            string nameRoot = "New Resource";
            int ModifierNumber = 0;
            string newName = "";

            while (!done)
            {
                done = true;
                newName = $"{nameRoot} {ModifierNumber}";
                foreach (ListViewItem resource in GlobalResourceList.Items)
                {
                    if (newName == resource.Text)
                    {
                        done = false;
                    }
                }
                ModifierNumber++;
            }

            Resource toBeAdded = new Resource(newName);

            ResourceManager.AddResource(toBeAdded);

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            GlobalResourceList.Clear();

            List<Resource> globalResources = ResourceManager.GetAllGlobalResources();
            foreach(Resource resource in globalResources)
            {
                GlobalResourceList.Items.Add(resource.name);
            }
        }

        private void RemoveResourceButton_Click(object sender, EventArgs e)
        {
            if (GlobalResourceList.SelectedItems.Count <= 0) return;

            ResourceManager.RemoveResource(GlobalResourceList.SelectedItems[0].Text);

            UpdateDisplay();
        }
    }
}
