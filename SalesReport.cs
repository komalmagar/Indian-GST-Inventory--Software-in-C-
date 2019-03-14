using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Configuration;
namespace komal
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet11.salesreturn' table. You can move, or remove it, as needed.
          //  this.salesreturnTableAdapter.Fill(this.masterDataSet11.salesreturn);

            this.reportViewer1.RefreshReport();
        }
    }
}
