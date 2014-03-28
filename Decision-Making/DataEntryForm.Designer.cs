namespace Decision_Making
{
    partial class DataEntryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.buyingVariableCost = new System.Windows.Forms.NumericUpDown();
            this.annualVolume = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.annualMakingCost = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.makingVariableCost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buyingVariableCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualMakingCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makingVariableCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost anual fix - cumparare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost variabil/unitate - cumparare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unitati anuale (volum)";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(228, 133);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Salveaza";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buyingVariableCost
            // 
            this.buyingVariableCost.Location = new System.Drawing.Point(199, 53);
            this.buyingVariableCost.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.buyingVariableCost.Name = "buyingVariableCost";
            this.buyingVariableCost.Size = new System.Drawing.Size(120, 20);
            this.buyingVariableCost.TabIndex = 10;
            // 
            // annualVolume
            // 
            this.annualVolume.Location = new System.Drawing.Point(199, 89);
            this.annualVolume.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.annualVolume.Name = "annualVolume";
            this.annualVolume.Size = new System.Drawing.Size(120, 20);
            this.annualVolume.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "fabricare";
            // 
            // annualMakingCost
            // 
            this.annualMakingCost.Location = new System.Drawing.Point(379, 25);
            this.annualMakingCost.Name = "annualMakingCost";
            this.annualMakingCost.Size = new System.Drawing.Size(120, 20);
            this.annualMakingCost.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "0";
            // 
            // makingVariableCost
            // 
            this.makingVariableCost.Location = new System.Drawing.Point(378, 53);
            this.makingVariableCost.Name = "makingVariableCost";
            this.makingVariableCost.Size = new System.Drawing.Size(120, 20);
            this.makingVariableCost.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "fabricare";
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 178);
            this.Controls.Add(this.makingVariableCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.annualMakingCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.annualVolume);
            this.Controls.Add(this.buyingVariableCost);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DataEntryForm";
            this.Text = "DataEntry";
            ((System.ComponentModel.ISupportInitialize)(this.buyingVariableCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualMakingCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makingVariableCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown buyingVariableCost;
        private System.Windows.Forms.NumericUpDown annualVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown annualMakingCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown makingVariableCost;
        private System.Windows.Forms.Label label7;
    }
}