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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddColumnsToTable();
            FillData();
        }

        private void FillData()
        {
            Product buying = null;
            Product making = null;

            try
            {
                buying = DataSaver.LoadData("Cumparare");
                making = DataSaver.LoadData("Fabricare");
            }

            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Nu exista date suficiente!");
            }

            finally
            {
                if (buying != null)
                {
                    this.totalCosts.Rows.Insert(0, "Cumparare", "0", buying.variableCost, buying.annualVolume);
                }

                if (making != null)
                {
                    this.totalCosts.Rows.Insert(1, "Fabricare", making.annualCost, making.variableCost, making.annualVolume);
                }
            }
        }

        private void AddColumnsToTable()
        {
            this.totalCosts.Columns.Add("Tip", "Tip");
            this.totalCosts.Columns.Add("Cost fix anual", "Cost fix anual");
            this.totalCosts.Columns.Add("Cost variabil/unitate", "Cost variabil/unitate");
            this.totalCosts.Columns.Add("Volum anual(unitati)", "Volum anual(unitati)");

            this.totalCosts.Rows.Add();
            this.totalCosts.Rows.Add();
        }

        private void insertDataButton_Click(object sender, EventArgs e)
        {
            DataEntryForm dataEntryForm = new DataEntryForm();
            dataEntryForm.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            AnalysingForm analysingForm = new AnalysingForm();
            analysingForm.Show();
        }
    }
}
