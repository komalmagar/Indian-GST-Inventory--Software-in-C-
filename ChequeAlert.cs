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
    public partial class ChequeAlert : Form
    {
        public ChequeAlert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentChequeAlert PCA = new PaymentChequeAlert();
            PCA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MYCollectionch mc = new MYCollectionch();
            mc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyVouchers mv = new MyVouchers();
            mv.Show();
        }
    }
}
