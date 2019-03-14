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
//using Microsoft.Office.Interop.Excel;

namespace komal
{
    public partial class HOME : Form
    {
        private int childFormNumber = 0;

        public HOME()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");
        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODUCTS pro = new PRODUCTS();
            pro.Show();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet11.stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.masterDataSet11.stocks);

        }
        private void Defeat()
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pur_Click(object sender, EventArgs e)
        {
            Purchases PUR = new Purchases();
            PUR.Show();





        }

        private void reports_Click(object sender, EventArgs e)
        {
            REPORTS re = new REPORTS();
            re.Show();
        }

        private void taxrepo_Click(object sender, EventArgs e)
        {

            TaxReport TR = new TaxReport();
            TR.Show();
        }

        private void PAY_Click(object sender, EventArgs e)
        {
            payments py = new payments();
            py.Show();
        }

        private void user_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
        }

        private void returnpicture_Click(object sender, EventArgs e)
        {
            returns res = new returns();
            res.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Passwordrecovery pass = new Passwordrecovery();
            pass.Show();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void sale_Click(object sender, EventArgs e)
        {
            Sales sl = new Sales();
            sl.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void acc_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do YOU WANT TO WATCH VIDIO", "VISIT", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=I3eCieDpG3o&t=778s");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }





        private void pictureBox7_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ViewAll_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void ViewAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewAll.Checked)
            {
                con.Open();
                SqlDataAdapter asdf20 = new SqlDataAdapter("select sum(quantity)  from purchaseentry", con);
                DataTable ss20 = new DataTable();
                asdf20.Fill(ss20);
                label7.Text = ss20.Rows[0][0].ToString();
                SqlDataAdapter asdf21 = new SqlDataAdapter("select sum(totalvalue) from purchaseentry", con);
                DataTable ss21 = new DataTable();
                asdf21.Fill(ss21);
                label8.Text = ss21.Rows[0][0].ToString();
                SqlDataAdapter asdf22 = new SqlDataAdapter("select sum(totalqty)  from taxinvoice", con);
                DataTable ss22 = new DataTable();
                asdf22.Fill(ss22);
                label23.Text = ss22.Rows[0][0].ToString();
                SqlDataAdapter asdf23 = new SqlDataAdapter("select sum(totalvalue)  from taxinvoice", con);
                DataTable ss23 = new DataTable();
                asdf23.Fill(ss23);
                label19.Text = ss23.Rows[0][0].ToString();
                SqlDataAdapter asdf24 = new SqlDataAdapter("select count(fromcustomer)  from salesreturn", con);
                DataTable ss24 = new DataTable();
                asdf24.Fill(ss24);
                label24.Text = ss24.Rows[0][0].ToString();
                SqlDataAdapter asdf25 = new SqlDataAdapter("select sum(totalvalue)  from salesreturn", con);
                DataTable ss25 = new DataTable();
                asdf25.Fill(ss25);
                label20.Text = ss25.Rows[0][0].ToString();
                SqlDataAdapter asdf26 = new SqlDataAdapter("select sum(gsttotal)  from  purchaseentry", con);
                DataTable ss26 = new DataTable();
                asdf26.Fill(ss26);
                label10.Text = ss26.Rows[0][0].ToString();
                ////////////saletax is remaining

                SqlDataAdapter asdf27 = new SqlDataAdapter("select sum(amount)  from  payments", con);
                DataTable ss27 = new DataTable();
                asdf27.Fill(ss27);
                label21.Text = ss27.Rows[0][0].ToString();

                SqlDataAdapter asdf28 = new SqlDataAdapter("select sum(amount)  from  collections", con);
                DataTable ss28 = new DataTable();
                asdf28.Fill(ss28);
                label22.Text = ss28.Rows[0][0].ToString();
                con.Close();
            }
            else
            {
                label7.Text = "0";
                label8.Text = "0.0";
                label23.Text = "0";
                label19.Text = "0.0";
                label24.Text = "0";
                label20.Text = "0.0";
                label10.Text = "0.0";
                label21.Text = "0.0";
                label22.Text = "0.0";
                   
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChequeAlert ca = new ChequeAlert();
            ca.Show();
        }

        private void HOME_FormClosing(object sender, FormClosingEventArgs e)
        {
            Defeat();
        }



        private void BACKUP_Click(object sender, EventArgs e)
        {
            BACKUP bk = new BACKUP();
            bk.Show();
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from stocks";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE FILL DATA FIRST OR PLEASE CONTACT THE PERSON");
            }
            finally
            {
                con.Close();
            }
            }
        }
    }

