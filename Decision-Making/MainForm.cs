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
        }

        DataEntryForm dataEntryForm = new DataEntryForm();

        private void insertDataButton_Click(object sender, EventArgs e)
        {
            dataEntryForm.Show();
        }

        AboutForm aboutForm = new AboutForm();

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }
    }
}
