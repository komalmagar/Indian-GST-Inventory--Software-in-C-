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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {


            con.Open();
            if ((custcode.Text == "") || (custname.Text == "") || (addr.Text == "") || (state.Text == "") || (pin.Text == "") || (dist.Text == "") || (gstnum.Text == "" ) ||(comboBox1.Text == "") )
            {
                MessageBox.Show("PLEASE FILL ALL DATA ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand commad;
                    String sql = "";

                    sql = "insert into customer(customerid,customername,address,city,pin,taluka,district,state,custtype,birthdate,adharnumber,mobile,email,pan,cstnumber,gstnumber,dlno20b,dlno21b,igst) values('" + custcode.Text + "','" + custname.Text + "','" + addr.Text + "','" + city.Text + "','" + pin.Text + "','" + tal.Text + "','" + dist.Text + "','" + state.Text + "','" + comboBox2.Text + "','" + birthdate.Text + "','" + textBox1.Text + "','" + mobile.Text + "','" + email1.Text + "','" + pan.Text + "','" + cst.Text + "','" + gstnum.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "' )";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    commad = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("INFORMATION SAVED SUCCESSFULLY", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    commad.Dispose();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            con.Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from customer";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception xe)
            {
                MessageBox.Show("PLEASE FILL DATA FIRST OR PLEASE CONTACT THE PERSON");
            }
        }


        private void clear_Click(object sender, EventArgs e)
        {
            custname.Clear();
            addr.Clear();
            city.Clear();
            pin.Clear();
            tal.Clear();
            dist.Clear();
            state.Clear();



            mobile.Clear();
            email1.Clear();
            pan.Clear();

            cst.Clear();

            gstnum.Clear();
            custcode.Clear();
            custcode.Focus();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("delete from customer where customerid='" + custcode.Text + "' AND customername='" + custname.Text + "' AND adharnumber='"+textBox1.Text+"'", con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR TO delete", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void customer_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                custcode.Text = selectedRow.Cells[0].Value.ToString();
                custname.Text = selectedRow.Cells[1].Value.ToString();
                addr.Text = selectedRow.Cells[2].Value.ToString();
                city.Text = selectedRow.Cells[3].Value.ToString();
                pin.Text = selectedRow.Cells[4].Value.ToString();
                tal.Text = selectedRow.Cells[5].Value.ToString();
                dist.Text = selectedRow.Cells[6].Value.ToString();
                state.Text = selectedRow.Cells[7].Value.ToString();
                comboBox2.Text = selectedRow.Cells[8].Value.ToString();
                birthdate.Text = selectedRow.Cells[9].Value.ToString();
                textBox1.Text = selectedRow.Cells[10].Value.ToString();
                mobile.Text = selectedRow.Cells[11].Value.ToString();
                email1.Text = selectedRow.Cells[12].Value.ToString();
                pan.Text = selectedRow.Cells[13].Value.ToString();
                cst.Text = selectedRow.Cells[14].Value.ToString();
                gstnum.Text = selectedRow.Cells[15].Value.ToString();
                textBox2.Text = selectedRow.Cells[16].Value.ToString();
                textBox3.Text = selectedRow.Cells[17].Value.ToString();
                comboBox1.Text = selectedRow.Cells[18].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select one at a time only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string maincon = ConfigurationManager.ConnectionStrings["MYCONN"].ConnectionString;
                string query = "select * from customer where customername='" + textBox4.Text + "'";
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(query, con);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc1 = new SqlCommand();
                sc1.CommandText = @"update customer set  customername='" + custname.Text + "' , address='" + addr.Text + "' , city='" + city.Text + "' , pin='" + pin.Text + "' , taluka='" + tal.Text + "' , district='" + dist.Text + "' , state='" + state.Text + "' ,  custtype='" + comboBox2.Text + "' , birthdate='" + birthdate.Text + "' ,adharnumber='" + textBox1.Text + "' ,mobile='" + mobile.Text + "' ,email='" + email1.Text + "' , pan='" + pan.Text + "' ,cstnumber='" + cst.Text + "' ,gstnumber='" + gstnum.Text + "' ,dlno20b='" + textBox2.Text + "' ,dlno21b='" + textBox3.Text + "'  where  customerid='" + custcode.Text + "'";
                sc1.Connection = con;
                sc1.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception)
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
