using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Decision_Making
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();

            try
            {
                LoadSavedData();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Nu exista date precedente");
            }
        }

        private void LoadSavedData()
        {
            Product product = new Product();
            product = DataSaver.LoadData();

            this.annualMakingCost.Value = System.Convert.ToDecimal(product.makingAnnualCost);
            this.buyingVariableCost.Value = System.Convert.ToDecimal(product.buyingVariableCost);
            this.makingVariableCost.Value = System.Convert.ToDecimal(makingVariableCost);
            this.annualVolume.Value = System.Convert.ToDecimal(product.annualVolume);
        }

        private bool checkEntryData()
        {
            bool result = false;

            if (this.annualMakingCost.Value > 0 &&
                this.buyingVariableCost.Value > 0 &&
                this.makingVariableCost.Value > 0 &&
                this.annualVolume.Value > 0)
            {
                result = true;
            }

            return result;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (checkEntryData() == true)
            {
                Product product = new Product();
                product.annualVolume = this.annualMakingCost.Value.ToString();
                product.buyingVariableCost = this.buyingVariableCost.Value.ToString();
                product.makingVariableCost = this.makingVariableCost.Value.ToString();
                product.annualVolume = this.annualVolume.Value.ToString();

                DataSaver.SaveData(product);
            }
            else
            {
                MessageBox.Show("Introduceti toate datele, va rog!");
            }
        }
    }
}
