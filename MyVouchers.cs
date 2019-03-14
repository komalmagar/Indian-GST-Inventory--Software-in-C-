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
    public partial class MyVouchers : Form
    {
        public MyVouchers()
        {
            InitializeComponent();
        }

        private void MyVouchers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expencess.expences' table. You can move, or remove it, as needed.
            this.expencesTableAdapter1.Fill(this.expencess.expences);
            // TODO: This line of code loads data into the 'Expences1.expences' table. You can move, or remove it, as needed.
            this.expencesTableAdapter.Fill(this.Expences1.expences);
            // TODO: This line of code loads data into the 'collections.collections' table. You can move, or remove it, as needed.
            //this.collectionsTableAdapter.Fill(this.collections.collections);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet2TableAdapters.expencesTableAdapter adapter = new DataSet2TableAdapters.expencesTableAdapter();
            DataSet2.expencesDataTable table = new DataSet2.expencesDataTable();

            adapter.FillByDate(table, fromdate.Text, todate.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet2TableAdapters.expencesTableAdapter adapter = new DataSet2TableAdapters.expencesTableAdapter();
            DataSet2.expencesDataTable table = new DataSet2.expencesDataTable();

            adapter.FillByPay(table,vender.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("DataSet1", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

    }
}
