
namespace GoldFinder
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocationList = new System.Windows.Forms.ListView();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.RemoveLocationButton = new System.Windows.Forms.Button();
            this.LocationName = new System.Windows.Forms.TextBox();
            this.EditSublocationsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labourSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationList
            // 
            this.LocationList.HideSelection = false;
            this.LocationList.Location = new System.Drawing.Point(181, 26);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(196, 339);
            this.LocationList.TabIndex = 0;
            this.LocationList.UseCompatibleStateImageBehavior = false;
            this.LocationList.SelectedIndexChanged += new System.EventHandler(this.LocationList_SelectedIndexChanged);
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Location = new System.Drawing.Point(12, 27);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(163, 23);
            this.AddLocationButton.TabIndex = 1;
            this.AddLocationButton.Text = "Add Location";
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // RemoveLocationButton
            // 
            this.RemoveLocationButton.Location = new System.Drawing.Point(12, 56);
            this.RemoveLocationButton.Name = "RemoveLocationButton";
            this.RemoveLocationButton.Size = new System.Drawing.Size(163, 23);
            this.RemoveLocationButton.TabIndex = 1;
            this.RemoveLocationButton.Text = "Remove Location";
            this.RemoveLocationButton.UseVisualStyleBackColor = true;
            this.RemoveLocationButton.Click += new System.EventHandler(this.RemoveLocationButton_Click);
            // 
            // LocationName
            // 
            this.LocationName.Location = new System.Drawing.Point(383, 26);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(217, 20);
            this.LocationName.TabIndex = 2;
            this.LocationName.TextChanged += new System.EventHandler(this.LocationName_TextChanged);
            // 
            // EditSublocationsButton
            // 
            this.EditSublocationsButton.Location = new System.Drawing.Point(383, 56);
            this.EditSublocationsButton.Name = "EditSublocationsButton";
            this.EditSublocationsButton.Size = new System.Drawing.Size(217, 23);
            this.EditSublocationsButton.TabIndex = 3;
            this.EditSublocationsButton.Text = "Edit Sub-Locations";
            this.EditSublocationsButton.UseVisualStyleBackColor = true;
            this.EditSublocationsButton.Click += new System.EventHandler(this.EditSublocationsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.worldToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourceSettingsToolStripMenuItem,
            this.labourSettingsToolStripMenuItem});
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.worldToolStripMenuItem.Text = "World";
            // 
            // resourceSettingsToolStripMenuItem
            // 
            this.resourceSettingsToolStripMenuItem.Name = "resourceSettingsToolStripMenuItem";
            this.resourceSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resourceSettingsToolStripMenuItem.Text = "Resource Settings";
            this.resourceSettingsToolStripMenuItem.Click += new System.EventHandler(this.ResourceSettingsToolStripMenuItem_Click);
            // 
            // labourSettingsToolStripMenuItem
            // 
            this.labourSettingsToolStripMenuItem.Name = "labourSettingsToolStripMenuItem";
            this.labourSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labourSettingsToolStripMenuItem.Text = "Labour Settings";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 372);
            this.Controls.Add(this.EditSublocationsButton);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.RemoveLocationButton);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.LocationList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LocationList;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.Button RemoveLocationButton;
        private System.Windows.Forms.TextBox LocationName;
        private System.Windows.Forms.Button EditSublocationsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourceSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labourSettingsToolStripMenuItem;
    }
}

