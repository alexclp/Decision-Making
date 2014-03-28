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
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.launchGraphicForm = new System.Windows.Forms.Button();
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
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(24, 179);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(574, 113);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.Text = "";
            // 
            // launchGraphicForm
            // 
            this.launchGraphicForm.Location = new System.Drawing.Point(277, 338);
            this.launchGraphicForm.Name = "launchGraphicForm";
            this.launchGraphicForm.Size = new System.Drawing.Size(75, 23);
            this.launchGraphicForm.TabIndex = 2;
            this.launchGraphicForm.Text = "Grafic";
            this.launchGraphicForm.UseVisualStyleBackColor = true;
            this.launchGraphicForm.Click += new System.EventHandler(this.launchGraphicForm_Click);
            // 
            // AnalysingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 373);
            this.Controls.Add(this.launchGraphicForm);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.costsGridView);
            this.Name = "AnalysingForm";
            this.Text = "AnalysingForm";
            ((System.ComponentModel.ISupportInitialize)(this.costsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView costsGridView;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button launchGraphicForm;

    }
}