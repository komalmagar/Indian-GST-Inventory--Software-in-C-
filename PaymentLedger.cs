using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
namespace komal
{
    public partial class PaymentLedger : Form
    {
        public PaymentLedger()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");

        private void PaymentLedger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet9.venderdetails' table. You can move, or remove it, as needed.
            this.venderdetailsTableAdapter2.Fill(this.masterDataSet9.venderdetails);
            // TODO: This line of code loads data into the 'AdventureWorksDataSet.payments' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'salesreturn12.salesreturn' table. You can move, or remove it, as needed.
          // this.payments1TableAdapter.Fill(this.AdventureWorksDataSet.payments);
            // TODO: This line of code loads data into the 'masterDataSet7.venderdetails' table. You can move, or remove it, as needed.

    
          
            // TODO: This line of code loads data into the 'masterDataSet12.salesreturn' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

      
        

        private void button1_Click(object sender, EventArgs e)
        {
            AdvancerworldDataSetxsdTableAdapters.paymentsTableAdapter adapter =new AdvancerworldDataSetxsdTableAdapters.paymentsTableAdapter();
            AdvancerworldDataSetxsd.paymentsDataTable table = new AdvancerworldDataSetxsd.paymentsDataTable();
            adapter.FillByVen(table, vendername.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("Staffname", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AdvancerworldDataSetxsdTableAdapters.paymentsTableAdapter adapter = new AdvancerworldDataSetxsdTableAdapters.paymentsTableAdapter();
            AdvancerworldDataSetxsd.paymentsDataTable table = new AdvancerworldDataSetxsd.paymentsDataTable();
            adapter.Fill(table);
            ReportDataSource MyNewDatSource = new ReportDataSource("Staffname", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

       

    }
}
