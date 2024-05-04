
namespace GoldFinder
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // LocationList
            // 
            this.LocationList.HideSelection = false;
            this.LocationList.Location = new System.Drawing.Point(182, 12);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(232, 601);
            this.LocationList.TabIndex = 0;
            this.LocationList.UseCompatibleStateImageBehavior = false;
            this.LocationList.SelectedIndexChanged += new System.EventHandler(this.LocationList_SelectedIndexChanged);
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Location = new System.Drawing.Point(13, 13);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(163, 23);
            this.AddLocationButton.TabIndex = 1;
            this.AddLocationButton.Text = "Add Location";
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // RemoveLocationButton
            // 
            this.RemoveLocationButton.Location = new System.Drawing.Point(13, 42);
            this.RemoveLocationButton.Name = "RemoveLocationButton";
            this.RemoveLocationButton.Size = new System.Drawing.Size(163, 23);
            this.RemoveLocationButton.TabIndex = 1;
            this.RemoveLocationButton.Text = "Remove Location";
            this.RemoveLocationButton.UseVisualStyleBackColor = true;
            this.RemoveLocationButton.Click += new System.EventHandler(this.RemoveLocationButton_Click);
            // 
            // LocationName
            // 
            this.LocationName.Location = new System.Drawing.Point(421, 12);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(217, 20);
            this.LocationName.TabIndex = 2;
            this.LocationName.TextChanged += new System.EventHandler(this.LocationName_TextChanged);
            // 
            // EditSublocationsButton
            // 
            this.EditSublocationsButton.Location = new System.Drawing.Point(421, 42);
            this.EditSublocationsButton.Name = "EditSublocationsButton";
            this.EditSublocationsButton.Size = new System.Drawing.Size(217, 23);
            this.EditSublocationsButton.TabIndex = 3;
            this.EditSublocationsButton.Text = "Edit Sub-Locations";
            this.EditSublocationsButton.UseVisualStyleBackColor = true;
            this.EditSublocationsButton.Click += new System.EventHandler(this.EditSublocationsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 625);
            this.Controls.Add(this.EditSublocationsButton);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.RemoveLocationButton);
            this.Controls.Add(this.AddLocationButton);
            this.Controls.Add(this.LocationList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LocationList;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.Button RemoveLocationButton;
        private System.Windows.Forms.TextBox LocationName;
        private System.Windows.Forms.Button EditSublocationsButton;
    }
}

