
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
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.DeleteRecipeButton = new System.Windows.Forms.Button();
            this.RecipeNameBox = new System.Windows.Forms.TextBox();
            this.RecipeListView = new System.Windows.Forms.ListView();
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
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(318, 58);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(174, 23);
            this.AddRecipeButton.TabIndex = 4;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DeleteRecipeButton
            // 
            this.DeleteRecipeButton.Location = new System.Drawing.Point(318, 88);
            this.DeleteRecipeButton.Name = "DeleteRecipeButton";
            this.DeleteRecipeButton.Size = new System.Drawing.Size(174, 23);
            this.DeleteRecipeButton.TabIndex = 5;
            this.DeleteRecipeButton.Text = "Delete Recipe";
            this.DeleteRecipeButton.UseVisualStyleBackColor = true;
            this.DeleteRecipeButton.Click += new System.EventHandler(this.DeleteRecipeButton_Click);
            // 
            // RecipeNameBox
            // 
            this.RecipeNameBox.Location = new System.Drawing.Point(667, 29);
            this.RecipeNameBox.Name = "RecipeNameBox";
            this.RecipeNameBox.Size = new System.Drawing.Size(144, 20);
            this.RecipeNameBox.TabIndex = 6;
            this.RecipeNameBox.TextChanged += new System.EventHandler(this.RecipeNameBox_TextChanged);
            // 
            // RecipeListView
            // 
            this.RecipeListView.HideSelection = false;
            this.RecipeListView.Location = new System.Drawing.Point(499, 29);
            this.RecipeListView.Name = "RecipeListView";
            this.RecipeListView.Size = new System.Drawing.Size(162, 409);
            this.RecipeListView.TabIndex = 7;
            this.RecipeListView.UseCompatibleStateImageBehavior = false;
            this.RecipeListView.SelectedIndexChanged += new System.EventHandler(this.RecipeListView_SelectedIndexChanged);
            // 
            // SubLocationsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.RecipeListView);
            this.Controls.Add(this.RecipeNameBox);
            this.Controls.Add(this.DeleteRecipeButton);
            this.Controls.Add(this.AddRecipeButton);
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
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.Button DeleteRecipeButton;
        private System.Windows.Forms.TextBox RecipeNameBox;
        private System.Windows.Forms.ListView RecipeListView;
    }
}