using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace komal
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }
       // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");
        private void StockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet14.purchaseentry' table. You can move, or remove it, as needed.
            this.purchaseentryTableAdapter1.Fill(this.masterDataSet14.purchaseentry);
            // TODO: This line of code loads data into the 'PurchaseEntry.purchaseentry' table. You can move, or remove it, as needed.
            //this.purchaseentryTableAdapter.Fill(this.PurchaseEntry.purchaseentry);
            // TODO: This line of code loads data into the 'Product.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.Product.product);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StockreportTableAdapters.purchaseentryTableAdapter adapter2 = new StockreportTableAdapters.purchaseentryTableAdapter();

            Stockreport.purchaseentryDataTable table2 = new Stockreport.purchaseentryDataTable();
            adapter2.FillByDate(table2, fromdate.Text, todate.Text);
                      
            ReportDataSource MyNewDatSource1 = new ReportDataSource("DataSet1", (DataTable)table2);
            this.reportViewer1.LocalReport.DataSources.Clear();
            
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StockreportTableAdapters.purchaseentryTableAdapter adapter2 = new StockreportTableAdapters.purchaseentryTableAdapter();

            Stockreport.purchaseentryDataTable table2 = new Stockreport.purchaseentryDataTable();
            adapter2.FillByVendor(table2, vendor.Text);
             ReportDataSource MyNewDatSource1 = new ReportDataSource("DataSet1", (DataTable)table2);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

    }
}
