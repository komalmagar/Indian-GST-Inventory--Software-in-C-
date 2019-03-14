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
    public partial class Add_Manufacturer_Details : Form
    {
        public Add_Manufacturer_Details()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-848LD0K;Integrated Security=True");
        private void Add_Manufacturer_Details_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from manufacturerdetails";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from manufacturerdetails";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLEASE FILL DATA FIRST OR PLEASE CONTACT THE PERSON");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView1.ColumnCount - 1;
            //for inserting data in the table;;;;;;;
            try
            {
                if (textBox1.Text == "" | textBox2.Text == "")
                {
                    MessageBox.Show("Please  enter all details");

                }
                else
                {
                    con.Open();
                    String query = "insert into manufacturerdetails (manufacturerid,manufacturername,address,city,mobile,igst,saletax,purchasetax) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    
                    MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE CONTACT THE PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        
        
    

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand sc = new SqlCommand("delete from manufacturerdetails where  manufacturerid='" + textBox1.Text + "' AND manufacturername='" + textBox2.Text + "' AND address='"+textBox3.Text+"' AND mobile='"+textBox5.Text+"' ", con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("PLEASE CONTACT THE PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[1].Value.ToString();
                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox4.Text = selectedRow.Cells[3].Value.ToString();
                textBox5.Text = selectedRow.Cells[4].Value.ToString();
                comboBox1.Text = selectedRow.Cells[5].Value.ToString();
                comboBox2.Text = selectedRow.Cells[6].Value.ToString();
                comboBox3.Text = selectedRow.Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE CONTACT THE PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string maincon = ConfigurationManager.ConnectionStrings["MYCONN"].ConnectionString;
                string query = "select * from manufacturerdetails where manufacturername='"+textBox9.Text+"'";
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(query, con);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE CONTACT THE PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc1 = new SqlCommand();
                sc1.CommandText = @"update manufacturerdetails set manufacturername='" + textBox2.Text + "' , address='" + textBox3.Text + "' , city='" + textBox4.Text + "' , mobile='" + textBox5.Text + "' , igst='" + comboBox1.Text + "' , saletax='" + comboBox2.Text + "' , purchasetax='" + comboBox3.Text + "'  where manufacturerid='"+textBox1.Text+"' ";
                sc1.Connection = con;
                sc1.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception )
            {

                MessageBox.Show("ERROR TO Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
