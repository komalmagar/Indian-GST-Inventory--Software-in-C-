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
    public partial class SalesLedger : Form
    {
        public SalesLedger()
        {
            InitializeComponent();
        }

        private void SalesLedger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collections._collections' table. You can move, or remove it, as needed.
            this.collectionsTableAdapter.Fill(this.collections._collections);
            // TODO: This line of code loads data into the 'MasterPurchase.taxinvoice' table. You can move, or remove it, as needed.
            this.taxinvoiceTableAdapter.Fill(this.MasterPurchase.taxinvoice);
            // TODO: This line of code loads data into the 'DataSet2.payments' table. You can move, or remove it, as needed.
          //  this.paymentsTableAdapter.Fill(this.salesreturn12.salesreturn);
            // TODO: This line of code loads data into the 'salesreturn12.salesreturn' table. You can move, or remove it, as needed.
           
     
            // TODO: This line of code loads data into the 'masterDataSet12.salesreturn' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            salesreturn12TableAdapters.collectionsTableAdapter adapter = new salesreturn12TableAdapters.collectionsTableAdapter(); ;
           salesreturn12.collectionsDataTable table = new salesreturn12.collectionsDataTable();
           adapter.FillByvendername(table, vendername.Text);
            ReportDataSource MyNewDataSource = new ReportDataSource("Collections",(DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            salesreturn12TableAdapters.collectionsTableAdapter adapter = new salesreturn12TableAdapters.collectionsTableAdapter(); ;
            salesreturn12.collectionsDataTable table = new salesreturn12.collectionsDataTable();
            adapter.Fill(table);
            ReportDataSource MyNewDataSource = new ReportDataSource("Collections", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
