﻿namespace Decision_Making
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
            this.label1 = new System.Windows.Forms.Label();
            this.typeOfAction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.annualFixedCost = new System.Windows.Forms.NumericUpDown();
            this.variableCostPerUnit = new System.Windows.Forms.NumericUpDown();
            this.annualVolume = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.annualFixedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableCostPerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalitate obtinere produs";
            // 
            // typeOfAction
            // 
            this.typeOfAction.FormattingEnabled = true;
            this.typeOfAction.Location = new System.Drawing.Point(183, 40);
            this.typeOfAction.Name = "typeOfAction";
            this.typeOfAction.Size = new System.Drawing.Size(121, 21);
            this.typeOfAction.TabIndex = 1;
            this.typeOfAction.SelectedIndexChanged += new System.EventHandler(this.typeOfAction_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost anual fix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost variabil/unitate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unitati anuale (volum)";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(229, 297);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Salveaza";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // annualFixedCost
            // 
            this.annualFixedCost.Enabled = false;
            this.annualFixedCost.Location = new System.Drawing.Point(183, 87);
            this.annualFixedCost.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.annualFixedCost.Name = "annualFixedCost";
            this.annualFixedCost.Size = new System.Drawing.Size(120, 20);
            this.annualFixedCost.TabIndex = 9;
            // 
            // variableCostPerUnit
            // 
            this.variableCostPerUnit.Enabled = false;
            this.variableCostPerUnit.Location = new System.Drawing.Point(183, 127);
            this.variableCostPerUnit.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.variableCostPerUnit.Name = "variableCostPerUnit";
            this.variableCostPerUnit.Size = new System.Drawing.Size(120, 20);
            this.variableCostPerUnit.TabIndex = 10;
            // 
            // annualVolume
            // 
            this.annualVolume.Enabled = false;
            this.annualVolume.Location = new System.Drawing.Point(183, 162);
            this.annualVolume.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.annualVolume.Name = "annualVolume";
            this.annualVolume.Size = new System.Drawing.Size(120, 20);
            this.annualVolume.TabIndex = 11;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 332);
            this.Controls.Add(this.annualVolume);
            this.Controls.Add(this.variableCostPerUnit);
            this.Controls.Add(this.annualFixedCost);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeOfAction);
            this.Controls.Add(this.label1);
            this.Name = "DataEntryForm";
            this.Text = "DataEntry";
            ((System.ComponentModel.ISupportInitialize)(this.annualFixedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableCostPerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeOfAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown annualFixedCost;
        private System.Windows.Forms.NumericUpDown variableCostPerUnit;
        private System.Windows.Forms.NumericUpDown annualVolume;
    }
}