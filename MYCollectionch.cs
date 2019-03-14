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
    public partial class MYCollectionch : Form
    {
        public MYCollectionch()
        {
            InitializeComponent();
        }

        private void MYCollectionch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collections.collections' table. You can move, or remove it, as needed.
                 }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
            DataSet1TableAdapters.collectionsTableAdapter adapter = new DataSet1TableAdapters.collectionsTableAdapter();
            //collectionsTableAdapters.collectionsTableAdapter adapter = new collectionsTableAdapters.collectionsTableAdapter();
            //collections.collectionsDataTable table = new komal.collections.collectionsDataTable();
            DataSet1.collectionsDataTable table = new DataSet1.collectionsDataTable();
            adapter.Fill(table);
            ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.collectionsTableAdapter adapter = new DataSet1TableAdapters.collectionsTableAdapter();
            //collectionsTableAdapters.collectionsTableAdapter adapter = new collectionsTableAdapters.collectionsTableAdapter();
            //collections.collectionsDataTable table = new komal.collections.collectionsDataTable();
            DataSet1.collectionsDataTable table = new DataSet1.collectionsDataTable();
            adapter.FillByDate(table, fromdate.Text,todate.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.collectionsTableAdapter adapter = new DataSet1TableAdapters.collectionsTableAdapter();
            //collectionsTableAdapters.collectionsTableAdapter adapter = new collectionsTableAdapters.collectionsTableAdapter();
            //collections.collectionsDataTable table = new komal.collections.collectionsDataTable();
            DataSet1.collectionsDataTable table = new DataSet1.collectionsDataTable();
            adapter.FillBy(table, vender.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DataSet1TableAdapters.collectionsTableAdapter adapter = new DataSet1TableAdapters.collectionsTableAdapter();
            //collectionsTableAdapters.collectionsTableAdapter adapter = new collectionsTableAdapters.collectionsTableAdapter();
            //collections.collectionsDataTable table = new komal.collections.collectionsDataTable();
            DataSet1.collectionsDataTable table = new DataSet1.collectionsDataTable();
            adapter.Fill(table);
            ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
