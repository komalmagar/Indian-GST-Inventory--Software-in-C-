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
    public partial class MyPrint : Form
    {
        public MyPrint()
        {
            InitializeComponent();
        }

        private void MyPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet18.taxinvoice' table. You can move, or remove it, as needed.
            this.taxinvoiceTableAdapter.Fill(this.masterDataSet18.taxinvoice);
            // TODO: This line of code loads data into the 'dataSet3.DataTable1' table. You can move, or remove it, as needed.
          // this.dataTable1TableAdapter.FillBYCUSTO(this.dataSet3.DataTable1);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DefaultTableAdapters.DataTable1TableAdapter adapter = new DefaultTableAdapters.DataTable1TableAdapter();
            Printdefault.DataTable1DataTable table = new Printdefault.DataTable1DataTable();
            adapter.FillVender(table, toname.Text);
            ReportDataSource MyNewDatSource1 = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
       
        }

        private void toname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
