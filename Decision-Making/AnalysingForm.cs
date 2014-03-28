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
                this.launchGraphicForm.Enabled = false;
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

                    string breakeven = ComputeBreakEven(product);
                    string toShow = null;

                    if (System.Convert.ToDecimal(makingTotalCost) > System.Convert.ToDecimal(buyingTotalCost))
                    {
                        toShow = String.Format("Pentru cantitatea introdusa, costul de fabricare al produsului este mai mare decat costul de cumparare, deci este recomandata cumpararea lui. ");
                    }
                    else
                    {
                        toShow = "Pentru volumul anual introdus introdusa, costul de cumparare al produsului este mai mare decat costul de fabricare, deci este recomandata fabricarea lui. ";
                    }

                    toShow += String.Format("Pentru o cantitate de {0}, alegerea este indiferenta. La un volum anual mai mic de {1}, este recomandata cumpararea produsului, iar la un volum anual mai mare, fabricarea lui.", breakeven, breakeven);
                    this.resultTextBox.Text = toShow;    
                }
            }
            
        }

        private string MakingCost(Product product)
        {
            decimal result = System.Convert.ToDecimal(product.makingAnnualCost) + System.Convert.ToDecimal(product.annualVolume) * System.Convert.ToDecimal(product.makingVariableCost);
            result = Math.Round(result);
            return result.ToString();
        }
        
        private string BuyingCost(Product product)
        {
            decimal result = 0 + System.Convert.ToDecimal(product.annualVolume) * System.Convert.ToDecimal(product.buyingVariableCost);
            result = Math.Round(result);
            return result.ToString();
        }
   
        private string ComputeBreakEven(Product product)
        {
            decimal result = (System.Convert.ToDecimal(product.makingAnnualCost) / Math.Abs(System.Convert.ToDecimal(product.buyingVariableCost) - System.Convert.ToDecimal(product.makingVariableCost)));
            result = Math.Round(result);
            return result.ToString();
        }

        private void launchGraphicForm_Click(object sender, EventArgs e)
        {
            GraphicForm form = new GraphicForm();
            form.Show();
        }
    }
}
