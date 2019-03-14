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
    public partial class PaymentChequeAlert : Form
    {
        public PaymentChequeAlert()
        {
            InitializeComponent();
        }

        private void PaymentChequeAlert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payment.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.payment.payments);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            PaymentChequeTableAdapters.paymentsTableAdapter adapter = new PaymentChequeTableAdapters.paymentsTableAdapter();
            PaymentCheque.paymentsDataTable table = new PaymentCheque.paymentsDataTable();
         

            adapter.FillByDate(table, fromdate.Text, todate.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("PaymentCheque", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PaymentChequeTableAdapters.paymentsTableAdapter adapter = new PaymentChequeTableAdapters.paymentsTableAdapter();
            PaymentCheque.paymentsDataTable table = new PaymentCheque.paymentsDataTable();


            adapter.Fill(table);
            ReportDataSource MyNewDatSource = new ReportDataSource("PaymentCheque", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentChequeTableAdapters.paymentsTableAdapter adapter = new PaymentChequeTableAdapters.paymentsTableAdapter();
            PaymentCheque.paymentsDataTable table = new PaymentCheque.paymentsDataTable();


            adapter.FillByvender(table,vender.Text);
            ReportDataSource MyNewDatSource = new ReportDataSource("PaymentCheque", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDatSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

    }
}
