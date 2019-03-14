using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace komal
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            customer cs = new customer();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TAXINVOICE ti = new TAXINVOICE();
            ti.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesReturn sr = new SalesReturn();
            sr.Show();
        }

       
    }
}
