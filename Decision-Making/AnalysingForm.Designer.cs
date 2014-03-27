namespace Decision_Making
{
    partial class AnalysingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.buyingCost = new System.Windows.Forms.Label();
            this.makingCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost anual pentru cumparare produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost anual pentru fabricare produs";
            // 
            // buyingCost
            // 
            this.buyingCost.AutoSize = true;
            this.buyingCost.Location = new System.Drawing.Point(271, 64);
            this.buyingCost.Name = "buyingCost";
            this.buyingCost.Size = new System.Drawing.Size(0, 13);
            this.buyingCost.TabIndex = 2;
            // 
            // makingCost
            // 
            this.makingCost.AutoSize = true;
            this.makingCost.Location = new System.Drawing.Point(256, 102);
            this.makingCost.Name = "makingCost";
            this.makingCost.Size = new System.Drawing.Size(0, 13);
            this.makingCost.TabIndex = 3;
            // 
            // AnalysingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 373);
            this.Controls.Add(this.makingCost);
            this.Controls.Add(this.buyingCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnalysingForm";
            this.Text = "AnalysingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label buyingCost;
        private System.Windows.Forms.Label makingCost;
    }
}