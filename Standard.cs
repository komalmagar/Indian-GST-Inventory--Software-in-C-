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
    public partial class Standard : Form
    {
        public Standard()
        {
            InitializeComponent();
        }

        private void Standard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet17.taxinvoice' table. You can move, or remove it, as needed.
            this.taxinvoiceTableAdapter.Fill(this.masterDataSet17.taxinvoice);

            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            DataSet3TableAdapters.DataTable1TableAdapter adapter = new DataSet3TableAdapters.DataTable1TableAdapter();
            DataSet3.DataTable1DataTable table = new DataSet3.DataTable1DataTable();
            adapter.FillBYCUSTO(table, toname.Text);

            ReportDataSource MyNewDatSource1 = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();*/
            standardTableAdapters.DataTable1TableAdapter adapter = new standardTableAdapters.DataTable1TableAdapter();
            standard.DataTable1DataTable table = new standard.DataTable1DataTable();
            adapter.FillVendor(table, toname.Text);
            ReportDataSource MyNewDatSource1 = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource1);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }
    }
}
