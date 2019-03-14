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
    public partial class DEFAULTPRINTER : Form
    {
        private string p;

        public DEFAULTPRINTER()
        {
            InitializeComponent();
        }

       

        private void DEFAULTPRINTER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet16.taxinvoice' table. You can move, or remove it, as needed.
           this.taxinvoiceTableAdapter.Fill(this.masterDataSet16.taxinvoice);
            // TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.FillBYCUSTO(this.DataSet3.DataTable1);
            // TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.FillBYCUSTO(this.DataSet3.DataTable1);
            // TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.FillBYCUSTO(this.DataSet3.DataTable1);

//            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
           // InitializeComponent();
                   }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataSet3TableAdapters.DataTable1TableAdapter adapter = new DataSet3TableAdapters.DataTable1TableAdapter();
            DataSet3.DataTable1DataTable table = new  DataSet3.DataTable1DataTable();
            adapter.FillBYCUSTO(table, toname.Text);
            
            ReportDataSource MyNewDatSource1 = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

        
    }
}
