
namespace IfElse_SwitchCase
{
    partial class Switch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpbxChooseCategory = new System.Windows.Forms.GroupBox();
            this.rdbtnHeroes = new System.Windows.Forms.RadioButton();
            this.rdbtnGods = new System.Windows.Forms.RadioButton();
            this.grpbxChooseCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleDescription = "";
            this.txtSearch.Location = new System.Drawing.Point(70, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(70, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpbxChooseCategory
            // 
            this.grpbxChooseCategory.Controls.Add(this.rdbtnHeroes);
            this.grpbxChooseCategory.Controls.Add(this.rdbtnGods);
            this.grpbxChooseCategory.Location = new System.Drawing.Point(70, 12);
            this.grpbxChooseCategory.Name = "grpbxChooseCategory";
            this.grpbxChooseCategory.Size = new System.Drawing.Size(143, 61);
            this.grpbxChooseCategory.TabIndex = 2;
            this.grpbxChooseCategory.TabStop = false;
            // 
            // rdbtnHeroes
            // 
            this.rdbtnHeroes.AutoSize = true;
            this.rdbtnHeroes.Location = new System.Drawing.Point(41, 38);
            this.rdbtnHeroes.Name = "rdbtnHeroes";
            this.rdbtnHeroes.Size = new System.Drawing.Size(59, 17);
            this.rdbtnHeroes.TabIndex = 3;
            this.rdbtnHeroes.Text = "Heroes";
            this.rdbtnHeroes.UseVisualStyleBackColor = true;
            // 
            // rdbtnGods
            // 
            this.rdbtnGods.AutoSize = true;
            this.rdbtnGods.Checked = true;
            this.rdbtnGods.Location = new System.Drawing.Point(41, 15);
            this.rdbtnGods.Name = "rdbtnGods";
            this.rdbtnGods.Size = new System.Drawing.Size(50, 17);
            this.rdbtnGods.TabIndex = 3;
            this.rdbtnGods.TabStop = true;
            this.rdbtnGods.Text = "Gods";
            this.rdbtnGods.UseVisualStyleBackColor = true;
            // 
            // Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 175);
            this.Controls.Add(this.grpbxChooseCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "Switch";
            this.Text = "Choose Your Hero or God";
            this.grpbxChooseCategory.ResumeLayout(false);
            this.grpbxChooseCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpbxChooseCategory;
        private System.Windows.Forms.RadioButton rdbtnHeroes;
        private System.Windows.Forms.RadioButton rdbtnGods;
    }
}

