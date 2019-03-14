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
    public partial class Passwordrecovery : Form
    {
        public Passwordrecovery()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-848LD0K;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter asdf = new SqlDataAdapter("select count(*) from test where Usrname='"+usernamevalue.Text+"' and passwords='"+oldpasswordvalue.Text+"' ",con);
            DataTable ds = new DataTable();
            asdf.Fill(ds);
            errorProvider1.Clear();
            if(ds.Rows[0][0].ToString() == "1")
            {
                if (newpasswordvalue.Text == confirmedpasswordvalue.Text)
                {
                    SqlDataAdapter cc = new SqlDataAdapter("update test set passwords='" + newpasswordvalue.Text + "' where Usrname='" + usernamevalue.Text + "' and passwords='" + oldpasswordvalue.Text + "'", con);
                    DataTable df = new DataTable();
                    cc.Fill(df);
                    MessageBox.Show("PASSWORD CHANGED.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(newpasswordvalue,"UnMatched Password");
                    errorProvider1.SetError(confirmedpasswordvalue, "UnMatched Password");
                }
                
            }
            else
            {
                errorProvider1.SetError(usernamevalue, "INCORRECT  USER NAME................");
                errorProvider1.SetError(usernamevalue, "INCORRECT  PASSWORD................");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbuttonvalue_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
