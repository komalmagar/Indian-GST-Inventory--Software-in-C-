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
    public partial class TaxReport : Form
    {
        public TaxReport()
        {
            InitializeComponent();
        }

       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PuchaseTaxInvoices PTI = new PuchaseTaxInvoices();
            PTI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesTaxInvoice STI = new SalesTaxInvoice();
            STI.Show();
        }

    }
}
