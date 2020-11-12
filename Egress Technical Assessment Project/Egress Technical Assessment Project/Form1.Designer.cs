namespace Egress_Technical_Assessment_Project
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
            this.beginSearch = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recipeImageBox = new System.Windows.Forms.PictureBox();
            this.searchInputBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // beginSearch
            // 
            this.beginSearch.Location = new System.Drawing.Point(262, 170);
            this.beginSearch.Name = "beginSearch";
            this.beginSearch.Size = new System.Drawing.Size(75, 23);
            this.beginSearch.TabIndex = 0;
            this.beginSearch.Text = "Search";
            this.beginSearch.UseVisualStyleBackColor = true;
            this.beginSearch.Click += new System.EventHandler(this.beginSearch_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AcceptsReturn = true;
            this.searchTextBox.Location = new System.Drawing.Point(6, 199);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(641, 463);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchInputBox
            // 
            this.searchInputBox.Location = new System.Drawing.Point(313, 144);
            this.searchInputBox.Name = "searchInputBox";
            this.searchInputBox.Size = new System.Drawing.Size(461, 20);
            this.searchInputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter ingredients you want seperated with a comma and plus (e.g peanut,chicken)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // recipeImageBox
            // 
            this.recipeImageBox.Location = new System.Drawing.Point(653, 199);
            this.recipeImageBox.Name = "recipeImageBox";
            this.recipeImageBox.Size = new System.Drawing.Size(275, 203);
            this.recipeImageBox.TabIndex = 4;
            this.recipeImageBox.TabStop = false;
            // 
            // searchInputBoxName
            // 
            this.searchInputBoxName.Location = new System.Drawing.Point(6, 144);
            this.searchInputBoxName.Name = "searchInputBoxName";
            this.searchInputBoxName.Size = new System.Drawing.Size(275, 20);
            this.searchInputBoxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter recipe name: e.g Pasta, Curry, Lemon";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "Recipe Finder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 745);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchInputBoxName);
            this.Controls.Add(this.recipeImageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchInputBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.beginSearch);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Finder";
            ((System.ComponentModel.ISupportInitialize)(this.recipeImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox searchInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox recipeImageBox;
        private System.Windows.Forms.TextBox searchInputBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

