
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngredientListView = new System.Windows.Forms.ListView();
            this.OutputListView = new System.Windows.Forms.ListView();
            this.AddInputButton = new System.Windows.Forms.Button();
            this.DeleteInputButton = new System.Windows.Forms.Button();
            this.AddOutputButton = new System.Windows.Forms.Button();
            this.DeleteOutputButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IngredientAmountBox = new System.Windows.Forms.TextBox();
            this.ResourceSelector = new System.Windows.Forms.ComboBox();
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
            this.SubLocationList.Activation = System.Windows.Forms.ItemActivation.OneClick;
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
            this.RecipeNameBox.Location = new System.Drawing.Point(671, 29);
            this.RecipeNameBox.Name = "RecipeNameBox";
            this.RecipeNameBox.Size = new System.Drawing.Size(249, 20);
            this.RecipeNameBox.TabIndex = 6;
            this.RecipeNameBox.TextChanged += new System.EventHandler(this.RecipeNameBox_TextChanged);
            // 
            // RecipeListView
            // 
            this.RecipeListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.RecipeListView.HideSelection = false;
            this.RecipeListView.Location = new System.Drawing.Point(499, 29);
            this.RecipeListView.Name = "RecipeListView";
            this.RecipeListView.Size = new System.Drawing.Size(162, 409);
            this.RecipeListView.TabIndex = 7;
            this.RecipeListView.UseCompatibleStateImageBehavior = false;
            this.RecipeListView.SelectedIndexChanged += new System.EventHandler(this.RecipeListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output";
            // 
            // IngredientListView
            // 
            this.IngredientListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.IngredientListView.HideSelection = false;
            this.IngredientListView.Location = new System.Drawing.Point(671, 100);
            this.IngredientListView.Name = "IngredientListView";
            this.IngredientListView.Size = new System.Drawing.Size(121, 338);
            this.IngredientListView.TabIndex = 9;
            this.IngredientListView.UseCompatibleStateImageBehavior = false;
            this.IngredientListView.SelectedIndexChanged += new System.EventHandler(this.IngredientListView_SelectedIndexChanged);
            // 
            // OutputListView
            // 
            this.OutputListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.OutputListView.HideSelection = false;
            this.OutputListView.Location = new System.Drawing.Point(925, 100);
            this.OutputListView.Name = "OutputListView";
            this.OutputListView.Size = new System.Drawing.Size(121, 338);
            this.OutputListView.TabIndex = 10;
            this.OutputListView.UseCompatibleStateImageBehavior = false;
            // 
            // AddInputButton
            // 
            this.AddInputButton.Location = new System.Drawing.Point(671, 58);
            this.AddInputButton.Name = "AddInputButton";
            this.AddInputButton.Size = new System.Drawing.Size(121, 23);
            this.AddInputButton.TabIndex = 11;
            this.AddInputButton.Text = "Add Input";
            this.AddInputButton.UseVisualStyleBackColor = true;
            this.AddInputButton.Click += new System.EventHandler(this.AddInputButton_Click);
            // 
            // DeleteInputButton
            // 
            this.DeleteInputButton.Location = new System.Drawing.Point(798, 59);
            this.DeleteInputButton.Name = "DeleteInputButton";
            this.DeleteInputButton.Size = new System.Drawing.Size(121, 23);
            this.DeleteInputButton.TabIndex = 11;
            this.DeleteInputButton.Text = "Delete Input";
            this.DeleteInputButton.UseVisualStyleBackColor = true;
            this.DeleteInputButton.Click += new System.EventHandler(this.DeleteInputButton_Click);
            // 
            // AddOutputButton
            // 
            this.AddOutputButton.Location = new System.Drawing.Point(926, 59);
            this.AddOutputButton.Name = "AddOutputButton";
            this.AddOutputButton.Size = new System.Drawing.Size(121, 23);
            this.AddOutputButton.TabIndex = 11;
            this.AddOutputButton.Text = "Add Output";
            this.AddOutputButton.UseVisualStyleBackColor = true;
            this.AddOutputButton.Click += new System.EventHandler(this.AddOutputButton_Click);
            // 
            // DeleteOutputButton
            // 
            this.DeleteOutputButton.Location = new System.Drawing.Point(1053, 59);
            this.DeleteOutputButton.Name = "DeleteOutputButton";
            this.DeleteOutputButton.Size = new System.Drawing.Size(121, 23);
            this.DeleteOutputButton.TabIndex = 11;
            this.DeleteOutputButton.Text = "Delete Output";
            this.DeleteOutputButton.UseVisualStyleBackColor = true;
            this.DeleteOutputButton.Click += new System.EventHandler(this.DeleteOutputButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(798, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resource";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Amount";
            // 
            // IngredientAmountBox
            // 
            this.IngredientAmountBox.Location = new System.Drawing.Point(798, 140);
            this.IngredientAmountBox.Name = "IngredientAmountBox";
            this.IngredientAmountBox.Size = new System.Drawing.Size(121, 20);
            this.IngredientAmountBox.TabIndex = 14;
            // 
            // ResourceSelector
            // 
            this.ResourceSelector.FormattingEnabled = true;
            this.ResourceSelector.Location = new System.Drawing.Point(798, 100);
            this.ResourceSelector.Name = "ResourceSelector";
            this.ResourceSelector.Size = new System.Drawing.Size(121, 21);
            this.ResourceSelector.TabIndex = 15;
            this.ResourceSelector.SelectedIndexChanged += new System.EventHandler(this.ResourceSelector_SelectedIndexChanged);
            // 
            // SubLocationsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 449);
            this.Controls.Add(this.ResourceSelector);
            this.Controls.Add(this.IngredientAmountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteOutputButton);
            this.Controls.Add(this.AddOutputButton);
            this.Controls.Add(this.DeleteInputButton);
            this.Controls.Add(this.AddInputButton);
            this.Controls.Add(this.OutputListView);
            this.Controls.Add(this.IngredientListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView IngredientListView;
        private System.Windows.Forms.ListView OutputListView;
        private System.Windows.Forms.Button AddInputButton;
        private System.Windows.Forms.Button DeleteInputButton;
        private System.Windows.Forms.Button AddOutputButton;
        private System.Windows.Forms.Button DeleteOutputButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IngredientAmountBox;
        private System.Windows.Forms.ComboBox ResourceSelector;
    }
}