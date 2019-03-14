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
    public partial class mytaxinvoice : Form
    {
        public mytaxinvoice()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            String query = "select to,address,area,cash,totalqty,aftervalue,credit,debit,gsttotal,cgst,sgst,igst,totalvalue from taxinvoice";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void disp_data()
        {

            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 2;

             dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView1.ColumnCount - 1;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select to,address,area,cash,totalqty,aftervalue,credit,debit,gsttotal,cgst,sgst,igst,totalvalue from venderdetails";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please  enter all details");

            }
            else
            {
                con.Open();
                String query = "insert into  taxinvoice  (to,address,area,cash,totalqty,free,invoiceno,productname,prcode,ratevalue,quantity,freeqty,discount,subtotal,discvalue,aftervalue,credit,debit,gsttotal,cgst,sgst,igst,totalvalue) values ('" + comboBox1.Text + "','" + comboBox4.Text + "','" + comboBox3.Text + "','" + cashval.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + invoicenoval.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + comboBox5.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'','" + textBox5.Text + "'','" + discountval.Text + "'','" + subtotalval.Text + "'','" + discvalu.Text + "'','" + afterdiscval.Text + "'','" + creditval.Text + "'','" + debitvaltaxvoice.Text + "'','" + gsttotalval.Text + "'','" + cgstval.Text + "'','" + sgstval.Text + "'','" + igstval.Text + "'','" + textBox7.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
           
        }

       private void mytaxinvoice_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from taxinvoice where to='" + comboBox1.Text + "' ";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            comboBox1.Text = selectedRow.Cells[0].Value.ToString();
            comboBox4.Text = selectedRow.Cells[1].Value.ToString();
            cashval.Text = selectedRow.Cells[2].Value.ToString();
            afterdiscval.Text = selectedRow.Cells[3].Value.ToString();
            creditval.Text = selectedRow.Cells[4].Value.ToString();
            debitvaltaxvoice.Text = selectedRow.Cells[5].Value.ToString();
            gsttotalval.Text = selectedRow.Cells[6].Value.ToString();
            cgstval.Text = selectedRow.Cells[7].Value.ToString();
            sgstval.Text = selectedRow.Cells[8].Value.ToString();
            igstval.Text = selectedRow.Cells[9].Value.ToString();
            textBox7.Text = selectedRow.Cells[10].Value.ToString();
        }

        private void mytaxinvoice_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productname1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productname1.product);
            // TODO: This line of code loads data into the 'customer1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customer1.customer);

        }

    }
}
