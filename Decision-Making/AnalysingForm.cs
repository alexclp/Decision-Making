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
            InitializeGridView();
        }

        private void InitializeGridView()
        {
            Product product = null;

            try
            {
                product = DataSaver.LoadData();
            }

            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Nu exista date!");
                return;
            }

            finally
            {
                if (product != null)
                {
                    string makingTotalCost = MakingCost(product);
                    string buyingTotalCost = BuyingCost(product);

                    this.costsGridView.Columns.Add("Tip", "Tip");
                    this.costsGridView.Columns.Add("Cost fix anual", "Cost fix anual");
                    this.costsGridView.Columns.Add("Cost variabil/unitate", "Cost variabil/unitate");
                    this.costsGridView.Columns.Add("Volum anual(unitati)", "Volum anual(unitati)");
                    this.costsGridView.Columns.Add("Cost total anual", "Cost total anual (calculat)");

                    this.costsGridView.Rows.Insert(0, "Fabricare", product.makingAnnualCost, product.makingVariableCost, product.annualVolume, makingTotalCost);
                    this.costsGridView.Rows.Insert(1, "Cumparare", "0", product.buyingVariableCost, product.annualVolume, buyingTotalCost);
                }
            }
            
        }

        private string MakingCost(Product product)
        {
            decimal result = System.Convert.ToDecimal(product.makingAnnualCost) + System.Convert.ToDecimal(product.annualVolume) * System.Convert.ToDecimal(product.makingVariableCost);
            return result.ToString();
        }
        
        private string BuyingCost(Product product)
        {
            decimal result = 0 + System.Convert.ToDecimal(product.annualVolume) * System.Convert.ToDecimal(product.buyingVariableCost);
            return result.ToString();
        }   
    }
}
