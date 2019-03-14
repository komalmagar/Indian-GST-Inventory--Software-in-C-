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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void addvendor_Click(object sender, EventArgs e)
        {
            payments pm = new payments();
            pm.Show();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {

        }

        private void addprodet_Click(object sender, EventArgs e)
        {
            Collections s = new Collections();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentLedger pl = new PaymentLedger();
            pl.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesLedger sl = new SalesLedger();
            sl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Extences ex = new Extences();
            ex.Show();
        }
    }
}
