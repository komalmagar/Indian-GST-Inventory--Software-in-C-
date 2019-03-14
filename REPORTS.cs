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
    public partial class REPORTS : Form
    {
        public REPORTS()
        {
            InitializeComponent();
        }

        private void REPORTS_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SalesTaxInvoice sti = new SalesTaxInvoice();
            sti.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            StockReport sr = new StockReport();
            sr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            StockAndSales sas = new StockAndSales();
            sas.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseTaxInvoice pti = new PurchaseTaxInvoice();
            pti.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesTaxInvoice sti = new SalesTaxInvoice();
            sti.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockReport sr = new StockReport();
            sr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            StockAndSales sas = new StockAndSales();
            sas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StockReport sr = new StockReport();
            sr.Show();
        }
    }
}
