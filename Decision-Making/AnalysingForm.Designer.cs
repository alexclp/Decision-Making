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
            this.costsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.costsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // costsGridView
            // 
            this.costsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.costsGridView.Location = new System.Drawing.Point(24, 23);
            this.costsGridView.Name = "costsGridView";
            this.costsGridView.Size = new System.Drawing.Size(574, 150);
            this.costsGridView.TabIndex = 0;
            // 
            // AnalysingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 373);
            this.Controls.Add(this.costsGridView);
            this.Name = "AnalysingForm";
            this.Text = "AnalysingForm";
            ((System.ComponentModel.ISupportInitialize)(this.costsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView costsGridView;

    }
}