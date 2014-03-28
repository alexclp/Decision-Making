namespace Decision_Making
{
    partial class GraphicForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.explanation = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.lineChart.Legends.Add(legend1);
            this.lineChart.Location = new System.Drawing.Point(12, 12);
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(568, 308);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "chart1";
            // 
            // explanation
            // 
            this.explanation.Location = new System.Drawing.Point(12, 326);
            this.explanation.Name = "explanation";
            this.explanation.Size = new System.Drawing.Size(568, 77);
            this.explanation.TabIndex = 1;
            this.explanation.Text = "";
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 415);
            this.Controls.Add(this.explanation);
            this.Controls.Add(this.lineChart);
            this.Name = "GraphicForm";
            this.Text = "Graphic";
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.RichTextBox explanation;
    }
}