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
    public partial class Extences : Form
    {
        public Extences()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Integrated Security=True;");
       // SqlConnection con1 = new SqlConnection(connectionClass.Connection());

        private void Extences_Load(object sender, EventArgs e)
        {
            disp_data();
            
        }
        
         public void disp_data()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from expences";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("THERE IS NO ANY DATA TO SHOW OR SOMETHING IS WRONG");
            }

        }

         private void button5_Click(object sender, EventArgs e)
         {
             //dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
             try
             {
                 dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView1.ColumnCount - 1;
                 con.Open();
                 if ((comboBox2.Text == "") || (comboBox1.Text == "") || (textBox4.Text == "") || (dateTimePicker1.Text == "") || (textBox5.Text == ""))
                 {
                     MessageBox.Show("PLEASE FILL ALL DATA WITH DATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 else
                 {
                     try
                     {
                         SqlCommand commad;
                         String sql = "";

                         sql = "insert into expences(paymentname,paymentmode,paymentdes,amount,voucherno,date,bankname,bankacc,ifsc,chequeno,chequedate) values('" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + dateTimePicker2.Text + "')";
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
                 try
                 {
                     SqlDataAdapter asdf = new SqlDataAdapter("select sum(amount)  from expences where paymentname='" + comboBox2.Text + "'", con);
                     DataTable ss = new DataTable();
                     asdf.Fill(ss);
                     textBox1.Text = ss.Rows[0][0].ToString();
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("NO ANy DATA FOR TOTAL AMount ");
                 }


                 con.Close();
             }
             catch (Exception)
             {
                 MessageBox.Show("Please fill all the Data with unique voucher number:");
             }
             
         }

         private void button3_Click(object sender, EventArgs e)
         {
             try
             {

                 con.Open();
                 textBox1.Clear();
                 SqlCommand sc = new SqlCommand("delete from expences where voucherno='" + textBox5.Text + "' AND paymentname='" + comboBox2.Text + "'  AND bankacc='"+textBox7.Text+"' AND chequeno='"+textBox9.Text+"'  AND ifsc='"+textBox8.Text+"'", con);
                 sc.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 con.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Something Wrong please contact person");
             }
         }

         private void button4_Click(object sender, EventArgs e)
         {
             textBox3.Clear();
             textBox4.Clear();
             textBox5.Clear();
             //dateTimePicker1.Clear();
             textBox6.Clear();
             textBox7.Clear();
             textBox8.Clear();
             textBox9.Clear();
                
         }

         private void button1_Click(object sender, EventArgs e)
         {
             try
             {
                 con.Open();
                 String query = "select * from expences  where date between '" + dateTimePicker3.Text + "' AND '" + dateTimePicker4.Text + "'";
                 SqlDataAdapter sda = new SqlDataAdapter(query, con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);
                 dataGridView1.DataSource = dt;
                 SqlDataAdapter asdf = new SqlDataAdapter("select sum(amount)  from expences where date between '" + dateTimePicker3.Text + "' AND '" + dateTimePicker4.Text + "'", con);
                 DataTable ss = new DataTable();
                 asdf.Fill(ss);
                 textBox1.Text = ss.Rows[0][0].ToString();


             }
             catch (Exception)
             {
                 MessageBox.Show("Contact The Person");
             }
             finally
             {
                 con.Close();
             }
        }

         

        

         private void label18_Click(object sender, EventArgs e)
         {
             
             
         }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             try
             {

                 int index = e.RowIndex;
                 DataGridViewRow selectedRow = dataGridView1.Rows[index];
                 comboBox2.Text = selectedRow.Cells[0].Value.ToString();

                 comboBox1.Text=selectedRow.Cells[1].Value.ToString();
                 textBox3.Text = selectedRow.Cells[2].Value.ToString();
                 textBox4.Text = selectedRow.Cells[3].Value.ToString();
                 textBox5.Text = selectedRow.Cells[4].Value.ToString();
                 dateTimePicker1.Text = selectedRow.Cells[5].Value.ToString();
                 textBox6.Text = selectedRow.Cells[6].Value.ToString();
                 textBox7.Text = selectedRow.Cells[7].Value.ToString();
                 textBox8.Text = selectedRow.Cells[8].Value.ToString();
                 textBox9.Text = selectedRow.Cells[9].Value.ToString();
                 dateTimePicker2.Text = selectedRow.Cells[10].Value.ToString(); ;
             }
             catch (Exception)
             {
                 MessageBox.Show("Please  select one cell at a time");
             }

         }

         private void button2_Click(object sender, EventArgs e)
         {
             try
             {
                 con.Open();
                 SqlCommand sc1 = new SqlCommand();
                 sc1.CommandText = @"update expences set paymentname='" + comboBox2.Text + "', paymentmode='" + comboBox1.Text + "' , paymentdes='" + textBox3.Text + "' , amount='" + textBox4.Text + "' , date='" + dateTimePicker1.Text + "' , bankname='" + textBox6.Text + "' , ifsc='" + textBox7.Text + "' ,  chequeno='" + textBox8.Text + "' , chequedate='" + dateTimePicker2.Text + "'   where   voucherno='" + textBox5.Text + "' ";
                 sc1.Connection = con;
                 sc1.ExecuteNonQuery();
                 MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

         private void button6_Click(object sender, EventArgs e)
         {
             try
             {
                 string maincon = System.Configuration.ConfigurationManager.ConnectionStrings["MYCONN"].ConnectionString;
                 string query = "select * from extences where paymentname='" + textBox10.Text + "'";
                 con.Open();
                 SqlCommand sqlcomm = new SqlCommand(query, con);
                 SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                 DataTable dt = new DataTable();
                 sdr.Fill(dt);
                 dataGridView1.DataSource = dt;
             }
             catch (Exception)
             {
                 MessageBox.Show("NO DATA TO SHOW", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             finally
             {
                 con.Close();
             }
         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }

         private void button7_Click(object sender, EventArgs e)
         {
             try
             {
                 con.Open();
                 String query = "select * from expences ";
                 SqlDataAdapter sda = new SqlDataAdapter(query, con);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);
                 dataGridView1.DataSource = dt;


             }
             catch (Exception)
             {
                 MessageBox.Show("Contact The Person");
             }
             finally
             {
                 con.Close();
             }
         }

         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             int index = e.RowIndex;
             DataGridViewRow selectedRow = dataGridView1.Rows[index];
             comboBox2.Text = selectedRow.Cells[0].Value.ToString();
             textBox1.Text = selectedRow.Cells[1].Value.ToString();
             //textBox2.Text = selectedRow.Cells[1].Value.ToString();
             textBox3.Text = selectedRow.Cells[2].Value.ToString();
             textBox4.Text = selectedRow.Cells[3].Value.ToString();
             textBox5.Text = selectedRow.Cells[4].Value.ToString();
             dateTimePicker1.Text = selectedRow.Cells[5].Value.ToString();
             textBox6.Text = selectedRow.Cells[6].Value.ToString();
             textBox7.Text = selectedRow.Cells[7].Value.ToString();
             textBox8.Text = selectedRow.Cells[8].Value.ToString();
             textBox9.Text = selectedRow.Cells[9].Value.ToString();
             dateTimePicker2.Text = selectedRow.Cells[10].Value.ToString();
         }

         }


    }


