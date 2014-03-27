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
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            this.typeOfAction.Items.Add("Fabricare");
            this.typeOfAction.Items.Add("Cumparare");
        }

        private void typeOfAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.typeOfAction.SelectedIndex == 0)
            {
                this.annualFixedCost.Enabled = true;
                this.variableCostPerUnit.Enabled = true;
                this.annualVolume.Enabled = true;
            } 
            else
            {
                this.annualFixedCost.Enabled = true;
                this.variableCostPerUnit.Enabled = false;
                this.annualVolume.Enabled = true;
            }
        }

        private bool checkEntryData()
        {
            if (this.typeOfAction.SelectedIndex == 0)
            {
                if (this.annualFixedCost.Value > 0 && this.variableCostPerUnit.Value > 0 && this.annualVolume.Value > 0)
                {
                    return true;
                }
                return false;
            } 
            else
            {
                if (this.annualFixedCost.Value > 0 && this.annualVolume.Value > 0)
                {
                    return true;
                }
                return false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (checkEntryData() == true)
            {
                Product product = new Product();
                product.annualCost = this.annualFixedCost.Value.ToString();
                product.variableCost = this.variableCostPerUnit.Value.ToString();
                product.annualVolume = this.annualVolume.Value.ToString();

                DataSaver.SaveData(product);
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti toate datele, va rog!");
            }
        }
    }
}
