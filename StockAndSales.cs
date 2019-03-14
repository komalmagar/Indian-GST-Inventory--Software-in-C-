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
    public partial class StockAndSales : Form
    {
        public StockAndSales()
        {
            InitializeComponent();
        }

        private void StockAndSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet12.salesreturn' table. You can move, or remove it, as needed.
            this.salesreturnTableAdapter1.Fill(this.masterDataSet12.salesreturn);
            // TODO: This line of code loads data into the 'Salereturn.salesreturn' table. You can move, or remove it, as needed.
           // this.salesreturnTableAdapter.Fill(this.Salereturn.salesreturn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockandSalesTableAdapters.salesreturnTableAdapter adapter = new StockandSalesTableAdapters.salesreturnTableAdapter();
            StockandSales.salesreturnDataTable table = new StockandSales.salesreturnDataTable();
            adapter.FillByDate(table, fromdate.Text, todate.Text);   
            ReportDataSource MyNewDatSource = new ReportDataSource("SalesReturn", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StockandSalesTableAdapters.salesreturnTableAdapter adapter = new StockandSalesTableAdapters.salesreturnTableAdapter();
            StockandSales.salesreturnDataTable table = new StockandSales.salesreturnDataTable();
            adapter.FillByVender(table, vendor.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("SalesReturn", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
