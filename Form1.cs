using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace komal
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from login where username='"+textBox1.Text+"' and  password='"+textBox2.Text+"'",con);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                hm.Show();
            }
            else
            {
                MessageBox.Show("failed some where");
            }
            
        }

        private void FORGETVALUE_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Passwordrecovery pr = new Passwordrecovery();
            pr.Show();
        }
    }
}
