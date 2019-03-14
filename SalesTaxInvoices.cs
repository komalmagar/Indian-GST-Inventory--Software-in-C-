using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace komal
{
    public partial class SalesTaxInvoices : Form
    {
        public SalesTaxInvoices()
        {
            InitializeComponent();
        }

        private void SalesTaxInvoices_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
