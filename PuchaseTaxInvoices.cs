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
    public partial class PuchaseTaxInvoices : Form
    {
        public PuchaseTaxInvoices()
        {
            InitializeComponent();
        }

        private void PuchaseTaxInvoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PurchasEntry.purchaseentry' table. You can move, or remove it, as needed.
            this.purchaseentryTableAdapter.Fill(this.PurchasEntry.purchaseentry);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaxesofPurchasesTableAdapters.purchaseentryTableAdapter adapter = new TaxesofPurchasesTableAdapters.purchaseentryTableAdapter();
            TaxesofPurchases.purchaseentryDataTable table = new TaxesofPurchases.purchaseentryDataTable();
            adapter.FillByDate(table, fromdate.Text, todate.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("PurchaseTaxInvoice", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TaxesofPurchasesTableAdapters.purchaseentryTableAdapter adapter = new TaxesofPurchasesTableAdapters.purchaseentryTableAdapter();
            TaxesofPurchases.purchaseentryDataTable table = new TaxesofPurchases.purchaseentryDataTable();
            adapter.FillBy(table);
            ReportDataSource MyNewDatSource = new ReportDataSource("PurchaseTaxInvoice", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
