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
    public partial class Vendordetails : Form
    {
        public Vendordetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from venderdetails";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand sc = new SqlCommand("delete from venderdetails where venderid='" + textBox1.Text + "' AND  vendername='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();

                MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR SOMETHNG CONTACT THE PERSON");
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
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //scrolling
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView1.ColumnCount - 1;
            //for inserting data in the table;;;;;;;
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please  enter ALL Details");

                }
                else
                {
                    con.Open();
                    String query = "insert into venderdetails (venderid,vendername,type,contactperson,mobile,address,city,email,gstno,cstno,dlno20b,dlno21b) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox12.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc1 = new SqlCommand();
                sc1.CommandText = @"update venderdetails set vendername='" + textBox2.Text + "' , type='" + textBox3.Text + "' , contactperson='" + textBox4.Text + "' , mobile='" + textBox5.Text + "' , address='" + textBox12.Text + "' , city='" + textBox6.Text + "' , email='" + textBox7.Text + "' , gstno='" + textBox8.Text + "' ,  cstno='" + textBox9.Text + "' , dlno20b='" + textBox10.Text + "' ,dlno21b='" + textBox11.Text + "'  where venderid='" + textBox1.Text + "'  ";
                sc1.Connection = con;
                sc1.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("ERROR TO Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from venderdetails";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void Vendordetails_Load(object sender, EventArgs e)
        {
            disp_data();
            
            string maincon = ConfigurationManager.ConnectionStrings["MYCONN"].ConnectionString;
            string query = "select * from venderdetails";
            con.Open();
            SqlCommand sqlcomm = new SqlCommand(query,con);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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
                textBox12.Text = selectedRow.Cells[5].Value.ToString();
                textBox6.Text = selectedRow.Cells[6].Value.ToString();
                textBox7.Text = selectedRow.Cells[7].Value.ToString();
                textBox8.Text = selectedRow.Cells[8].Value.ToString();
                textBox9.Text = selectedRow.Cells[9].Value.ToString();
                textBox10.Text = selectedRow.Cells[10].Value.ToString();
                textBox11.Text = selectedRow.Cells[11].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select one at a time only");
            }


        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string maincon = ConfigurationManager.ConnectionStrings["MYCONN"].ConnectionString;

                string query = "select * from venderdetails where vendername='" + textBox13.Text + "'";
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(query, con);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("No Any Vendor By this Name");
            }
            finally
            {
                con.Close();
            }
        }
    }
       
    }

