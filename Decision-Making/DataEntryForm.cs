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
            
        }
    }
}
