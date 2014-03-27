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
    public partial class AnalysingForm : Form
    {
        public AnalysingForm()
        {
            InitializeComponent();

            ComputeData();
        }

        private void ComputeData()
        {
            Product buying = new Product();
            Product making = new Product();

            try
            {
                buying = DataSaver.LoadData("Cumparare");
                making = DataSaver.LoadData("Fabricare");
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("Nu exista date suficiente pentru analizare!");
                return;
            }

            decimal makingTotalCost = 0 + System.Convert.ToDecimal(making.annualVolume) * System.Convert.ToDecimal(making.variableCost);
            decimal buyingTotalCost = System.Convert.ToDecimal(buying.annualCost) + System.Convert.ToDecimal(buying.annualVolume) * System.Convert.ToDecimal(making.variableCost);

            this.makingCost.Text = makingTotalCost.ToString();
            this.buyingCost.Text = buyingTotalCost.ToString();
        }
    }
}
