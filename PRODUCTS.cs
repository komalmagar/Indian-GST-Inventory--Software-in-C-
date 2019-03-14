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
    public partial class PRODUCTS : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-848LD0K;Integrated Security=True");
        public PRODUCTS()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PRODUCTS_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        

       

        
        public static void main(string[] args)
        {
            Application.Run(new PRODUCTS());
        }

        private void save_Click(object sender, EventArgs e)
        {
            //scrolling
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView1.ColumnCount - 1;
            //for inserting data in the table;;;;;;;
            try
            {
                if (productcode.Text != "")
                {
                    con.Open();
                    String query = "insert into product (productname,productcode,packaging,hsncode,manufacturer,sceduleddrug,saletax,purchasetax) values ('" + productname.Text + "','" + productcode.Text + "','" + packing.Text + "','" + hsncode.Text + "','" + manufacturer.Text + "','" + scheduleddrug.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Please  enter Productcode");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("YOU DID WRONG SOMEWHERE", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "select * from product";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand sc = new SqlCommand("delete from product where productname='" + productname.Text+ "' AND productcode='" + productcode.Text + "' AND packaging='" +packing.Text+ "' AND hsncode='" + hsncode.Text + "' AND manufacturer='" +manufacturer.Text+ "' AND sceduleddrug='" + scheduleddrug.Text + "' AND saletax='" +comboBox1.Text+ "' AND purchasetax='"+comboBox2.Text+"' ", con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("PLEASE CONTACT THE PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            productcode.Clear();
            productname.Clear();
            hsncode.Clear();
            scheduleddrug.Clear();
            packing.Clear();
            manufacturer.Clear();
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            productname.Text = selectedRow.Cells[0].Value.ToString();
            productcode.Text = selectedRow.Cells[1].Value.ToString();
            packing.Text = selectedRow.Cells[2].Value.ToString();
            hsncode.Text = selectedRow.Cells[3].Value.ToString();
             manufacturer.Text = selectedRow.Cells[4].Value.ToString();
             scheduleddrug.Text = selectedRow.Cells[5].Value.ToString();
             comboBox1.Text = selectedRow.Cells[6].Value.ToString();
             comboBox2.Text = selectedRow.Cells[7].Value.ToString();
             //productcode.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void productcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc1 = new SqlCommand();
                sc1.CommandText = @"update product set productname='" + productname.Text + "' , productcode='" + productcode.Text + "' , packaging='" + packing.Text + "' ,manufacturer='" + manufacturer.Text + "' , sceduleddrug='" + scheduleddrug.Text + "' , saletax='" + comboBox1.Text + "' , purchasetax='" + comboBox2.Text + "'  where hsncode='" + hsncode.Text + "' ";
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

