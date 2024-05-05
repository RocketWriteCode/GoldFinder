
namespace GoldFinder
{
    partial class SubLocationsMenu
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
            this.LocationName = new System.Windows.Forms.Label();
            this.SubLocationList = new System.Windows.Forms.ListView();
            this.AddSublocationButton = new System.Windows.Forms.Button();
            this.RemoveSublocationButton = new System.Windows.Forms.Button();
            this.SublocationNameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Location = new System.Drawing.Point(13, 13);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(35, 13);
            this.LocationName.TabIndex = 0;
            this.LocationName.Text = "label1";
            // 
            // SubLocationList
            // 
            this.SubLocationList.HideSelection = false;
            this.SubLocationList.Location = new System.Drawing.Point(149, 29);
            this.SubLocationList.Name = "SubLocationList";
            this.SubLocationList.Size = new System.Drawing.Size(162, 409);
            this.SubLocationList.TabIndex = 1;
            this.SubLocationList.UseCompatibleStateImageBehavior = false;
            this.SubLocationList.SelectedIndexChanged += new System.EventHandler(this.SubLocationList_SelectedIndexChanged);
            // 
            // AddSublocationButton
            // 
            this.AddSublocationButton.Location = new System.Drawing.Point(16, 29);
            this.AddSublocationButton.Name = "AddSublocationButton";
            this.AddSublocationButton.Size = new System.Drawing.Size(127, 23);
            this.AddSublocationButton.TabIndex = 2;
            this.AddSublocationButton.Text = "Add Sub-Location";
            this.AddSublocationButton.UseVisualStyleBackColor = true;
            this.AddSublocationButton.Click += new System.EventHandler(this.AddSublocationButton_Click);
            // 
            // RemoveSublocationButton
            // 
            this.RemoveSublocationButton.Location = new System.Drawing.Point(16, 58);
            this.RemoveSublocationButton.Name = "RemoveSublocationButton";
            this.RemoveSublocationButton.Size = new System.Drawing.Size(127, 23);
            this.RemoveSublocationButton.TabIndex = 2;
            this.RemoveSublocationButton.Text = "Remove Sub-Location";
            this.RemoveSublocationButton.UseVisualStyleBackColor = true;
            this.RemoveSublocationButton.Click += new System.EventHandler(this.RemoveSublocationButton_Click);
            // 
            // SublocationNameField
            // 
            this.SublocationNameField.Location = new System.Drawing.Point(318, 29);
            this.SublocationNameField.Name = "SublocationNameField";
            this.SublocationNameField.Size = new System.Drawing.Size(174, 20);
            this.SublocationNameField.TabIndex = 3;
            this.SublocationNameField.TextChanged += new System.EventHandler(this.SublocationNameField_TextChanged);
            // 
            // SubLocationsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SublocationNameField);
            this.Controls.Add(this.RemoveSublocationButton);
            this.Controls.Add(this.AddSublocationButton);
            this.Controls.Add(this.SubLocationList);
            this.Controls.Add(this.LocationName);
            this.Name = "SubLocationsMenu";
            this.Text = "SubLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.ListView SubLocationList;
        private System.Windows.Forms.Button AddSublocationButton;
        private System.Windows.Forms.Button RemoveSublocationButton;
        private System.Windows.Forms.TextBox SublocationNameField;
    }
}