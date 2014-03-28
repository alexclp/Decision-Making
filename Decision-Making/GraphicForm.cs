using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Making
{
    public partial class GraphicForm : Form
    {
        public GraphicForm()
        {
            InitializeComponent();
            DrawChart();

            WriteExplanation();
        }
        
        private void WriteExplanation()
        {
            Product product = new Product();
            product = DataSaver.LoadData();

            string breakeven = Product.ComputeBreakEven(product);

            this.explanation.Text = String.Format("Dupa cum se poate observa si pe grafic, punctul unde decisiv este determinat de intersectia pe grafic in punctul X = {0}.", breakeven);
        }

        private void DrawChart()
        {
            Product product = new Product();
            product = DataSaver.LoadData();

            string buyTotalCost = Product.BuyingCost(product);
            string makeTotalCost = Product.MakingCost(product);
            string units = Math.Round((System.Convert.ToDouble(product.annualVolume) * 0.5)).ToString();

            int annualVolume = System.Convert.ToInt32(product.annualVolume);
             
            this.lineChart.Series.Add("Cost total cumparare");
            this.lineChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Int64 sum = 0;
            for (int i = 1; i < annualVolume; ++i)
            {
                sum = i * System.Convert.ToInt32(product.buyingVariableCost);
                this.lineChart.Series[0].Points.AddXY(i, sum);
            }

            this.lineChart.Series.Add("Cost fix fabricare");
            this.lineChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            sum = 0;
            Int64 toAdd = System.Convert.ToInt64(product.makingAnnualCost);
            Int64 toMultiply = System.Convert.ToInt64(product.makingVariableCost);
            for (int i = 1; i < annualVolume; ++i)
            {
                sum = toAdd + i * toMultiply;
                this.lineChart.Series[1].Points.AddXY(i, sum);
            }

            this.lineChart.Series.Add("Cost variabil fabricare");
            this.lineChart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 1; i < annualVolume; ++i)
            {
                this.lineChart.Series[2].Points.AddXY(i, toAdd);
            }
        }
    }
}
