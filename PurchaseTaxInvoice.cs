using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace komal
{
    public partial class PurchaseTaxInvoice : Form
    {
        public PurchaseTaxInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseTaxInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MasterPurchase.taxinvoice' table. You can move, or remove it, as needed.
            this.taxinvoiceTableAdapter.Fill(this.MasterPurchase.taxinvoice);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            purchasetaxinvoiceTableAdapters.taxinvoiceTableAdapter adapter = new purchasetaxinvoiceTableAdapters.taxinvoiceTableAdapter();
            purchasetaxinvoice.taxinvoiceDataTable table = new purchasetaxinvoice.taxinvoiceDataTable();
            adapter.FillByDate(table, fromdate.Text, todate.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("PurchaseInvoice", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            purchasetaxinvoiceTableAdapters.taxinvoiceTableAdapter adapter = new purchasetaxinvoiceTableAdapters.taxinvoiceTableAdapter();
            purchasetaxinvoice.taxinvoiceDataTable table = new purchasetaxinvoice.taxinvoiceDataTable();
            adapter.Fill(table);
            ReportDataSource MyNewDatSource = new ReportDataSource("PurchaseInvoice", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            purchasetaxinvoiceTableAdapters.taxinvoiceTableAdapter adapter = new purchasetaxinvoiceTableAdapters.taxinvoiceTableAdapter();
            purchasetaxinvoice.taxinvoiceDataTable table = new purchasetaxinvoice.taxinvoiceDataTable();
            adapter.Fill(table);
            ReportDataSource MyNewDatSource = new ReportDataSource("PurchaseInvoice", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
