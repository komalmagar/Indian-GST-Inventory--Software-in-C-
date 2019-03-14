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
    public partial class SalesTaxInvoice : Form
    {
        public SalesTaxInvoice()
        {
            InitializeComponent();
        }

        private void SalesTaxInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TaxInvoice1.taxinvoice' table. You can move, or remove it, as needed.
            //this.taxinvoiceTableAdapter.Fill(this.TaxInvoice1.taxinvoice);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySalesTableAdapters.salesreturnTableAdapter adapter = new MySalesTableAdapters.salesreturnTableAdapter();
            MySales.salesreturnDataTable table = new MySales.salesreturnDataTable();
            
            adapter.FillByDateval(table, fromdate.Text, todate.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {


                MySalesTableAdapters.salesreturnTableAdapter adapter = new MySalesTableAdapters.salesreturnTableAdapter();
                MySales.salesreturnDataTable table = new MySales.salesreturnDataTable();

                adapter.FillByDate(table);
                ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
           

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }


    }
}
