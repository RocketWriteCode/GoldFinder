
namespace GoldFinder
{
    partial class ResourceSettingsWindow
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
            this.AddResourceButton = new System.Windows.Forms.Button();
            this.GlobalResourceList = new System.Windows.Forms.ListView();
            this.RemoveResourceButton = new System.Windows.Forms.Button();
            this.ResourceNameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddResourceButton
            // 
            this.AddResourceButton.Location = new System.Drawing.Point(12, 12);
            this.AddResourceButton.Name = "AddResourceButton";
            this.AddResourceButton.Size = new System.Drawing.Size(119, 23);
            this.AddResourceButton.TabIndex = 0;
            this.AddResourceButton.Text = "Add Resource";
            this.AddResourceButton.UseVisualStyleBackColor = true;
            this.AddResourceButton.Click += new System.EventHandler(this.AddResourceButton_Click);
            // 
            // GlobalResourceList
            // 
            this.GlobalResourceList.HideSelection = false;
            this.GlobalResourceList.Location = new System.Drawing.Point(137, 12);
            this.GlobalResourceList.Name = "GlobalResourceList";
            this.GlobalResourceList.Size = new System.Drawing.Size(158, 426);
            this.GlobalResourceList.TabIndex = 1;
            this.GlobalResourceList.UseCompatibleStateImageBehavior = false;
            this.GlobalResourceList.View = System.Windows.Forms.View.List;
            this.GlobalResourceList.SelectedIndexChanged += new System.EventHandler(this.GlobalResourceList_SelectedIndexChanged);
            // 
            // RemoveResourceButton
            // 
            this.RemoveResourceButton.Location = new System.Drawing.Point(12, 41);
            this.RemoveResourceButton.Name = "RemoveResourceButton";
            this.RemoveResourceButton.Size = new System.Drawing.Size(119, 23);
            this.RemoveResourceButton.TabIndex = 2;
            this.RemoveResourceButton.Text = "Remove Resource";
            this.RemoveResourceButton.UseVisualStyleBackColor = true;
            this.RemoveResourceButton.Click += new System.EventHandler(this.RemoveResourceButton_Click);
            // 
            // ResourceNameField
            // 
            this.ResourceNameField.Location = new System.Drawing.Point(302, 12);
            this.ResourceNameField.Name = "ResourceNameField";
            this.ResourceNameField.Size = new System.Drawing.Size(179, 20);
            this.ResourceNameField.TabIndex = 3;
            this.ResourceNameField.TextChanged += new System.EventHandler(this.ResourceNameField_TextChanged);
            // 
            // ResourceSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResourceNameField);
            this.Controls.Add(this.RemoveResourceButton);
            this.Controls.Add(this.GlobalResourceList);
            this.Controls.Add(this.AddResourceButton);
            this.Name = "ResourceSettingsWindow";
            this.Text = "Resource Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddResourceButton;
        private System.Windows.Forms.ListView GlobalResourceList;
        private System.Windows.Forms.Button RemoveResourceButton;
        private System.Windows.Forms.TextBox ResourceNameField;
    }
}