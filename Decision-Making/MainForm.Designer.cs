namespace Decision_Making
{
    partial class MainForm
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
            this.insertDataButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.totalCosts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.totalCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // insertDataButton
            // 
            this.insertDataButton.Location = new System.Drawing.Point(225, 211);
            this.insertDataButton.Name = "insertDataButton";
            this.insertDataButton.Size = new System.Drawing.Size(122, 23);
            this.insertDataButton.TabIndex = 0;
            this.insertDataButton.Text = "Introduce date";
            this.insertDataButton.UseVisualStyleBackColor = true;
            this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(225, 269);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(122, 23);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "Despre";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(225, 240);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(122, 23);
            this.analyzeButton.TabIndex = 2;
            this.analyzeButton.Text = "Analizeaza";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // totalCosts
            // 
            this.totalCosts.AllowUserToAddRows = false;
            this.totalCosts.AllowUserToDeleteRows = false;
            this.totalCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalCosts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.totalCosts.Location = new System.Drawing.Point(12, 12);
            this.totalCosts.Name = "totalCosts";
            this.totalCosts.Size = new System.Drawing.Size(548, 193);
            this.totalCosts.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 352);
            this.Controls.Add(this.totalCosts);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.insertDataButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.totalCosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertDataButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.DataGridView totalCosts;
    }
}

