using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    public class Product
    {
        public string makingAnnualCost { get; set; }
        public string makingVariableCost { get; set; }
        public string buyingVariableCost { get; set; }
        public string annualVolume { get; set; }

        public static string MakingCost(Product product)
        {
            decimal result = System.Convert.ToDecimal(product.makingAnnualCost) + System.Convert.ToDecimal(product.annualVolume) * System.Convert.ToDecimal(product.makingVariableCost);
            result = Math.Round(result);
            return result.ToString();
        }

        public static string BuyingCost(Product product)
        {
            decimal result = 0 + System.Convert.ToDecimal(product.annualVolume) * System.Convert.ToDecimal(product.buyingVariableCost);
            result = Math.Round(result);
            return result.ToString();
        }

        public static string ComputeBreakEven(Product product)
        {
            decimal result = (System.Convert.ToDecimal(product.makingAnnualCost) / Math.Abs(System.Convert.ToDecimal(product.buyingVariableCost) - System.Convert.ToDecimal(product.makingVariableCost)));
            result = Math.Round(result);
            return result.ToString();
        }

        public static void launchGraphicForm_Click(object sender, EventArgs e)
        {
            GraphicForm form = new GraphicForm();
            form.Show();
        }
    }
}
