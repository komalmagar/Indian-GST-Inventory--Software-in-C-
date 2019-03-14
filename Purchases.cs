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
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
        }

        private void addvendor_Click(object sender, EventArgs e)
        {
            Vendordetails vd = new Vendordetails();
            vd.Show();
        }

        private void addprodet_Click(object sender, EventArgs e)
        {
            PRODUCTS pr = new PRODUCTS();
            pr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Manufacturer_Details amd = new Add_Manufacturer_Details();
            amd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddVendors av = new AddVendors();
            av.Show();
        }
    }
}
