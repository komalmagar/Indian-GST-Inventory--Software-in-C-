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
    public partial class payments : Form
    {
        public payments()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Integrated Security=True;");

        private void PAY_Click(object sender, EventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView1.ColumnCount - 1;
            con.Open();
            if ((vendernamevalu.Text == "") || (PAYOPTIONVALUE.Text == "")|| (banknamevalue.Text == "") || (bankaccountvalue.Text == "") || (ipscvalue.Text == "") || (chequenovalue.Text == "") || (amountvalue.Text == ""))
            {
                MessageBox.Show("PLEASE FILL ALL DATA ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                try
                {
                    SqlCommand commad;
                    String sql = "";

                    sql = "insert into payments(vendername,totalvalue,paymentmode,paymentdesc,bankname,bankaccount,ipsc,chequeno,chequedate,voucherno,date,invoiceno,discount,amount) values('"+vendernamevalu.Text + "','" + totalvaluetext.Text + "','" + PAYOPTIONVALUE.Text + "','" + paymentdescrptionvalue.Text + "','" + banknamevalue.Text + "','" + bankaccountvalue.Text + "','" + ipscvalue.Text + "','" + chequenovalue.Text + "','" + chequedatevalue.Text + "','" + vouchernumbervalue.Text + "','" + datevalue.Text + "','" + invoicenumbervalue.Text + "','" + discountvalue.Text + "','" + amountvalue.Text + "')";
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

        private void View_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from payments";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Contact The Person");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            totalvaluetext.Clear();
            paymentdescrptionvalue.Clear();
            banknamevalue.Clear();
            bankaccountvalue.Clear();
            ipscvalue.Clear();
            chequenovalue.Clear();
            vouchernumbervalue.Clear();
            discountvalue.Clear();
            amountvalue.Clear();
            vendernamevalu.Focus();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc1 = new SqlCommand();
                sc1.CommandText = @"update payments set vendername='" + vendernamevalu.Text + "' , totalvalue='" + totalvaluetext.Text + "' , paymentmode='" + PAYOPTIONVALUE.Text + "' , paymentdesc='" + paymentdescrptionvalue.Text + "' , bankname='" + banknamevalue.Text + "' , bankaccount='" + bankaccountvalue.Text + "' , ipsc='" + ipscvalue.Text + "', chequedate='" + chequedatevalue.Text + "' ,voucherno='" + vouchernumbervalue.Text + "',date='" + datevalue.Text + "' , invoiceno='" + invoicenumbervalue.Text + "' , discount='" + discountvalue.Text + "' , amount='" +amountvalue.Text+ "' where   chequeno='" + chequenovalue.Text + "' ";
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

        private void gatdata_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select  * from payments where vendername='" + vendernamevalu.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please contact the Person");
            }
        }

       
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand sc = new SqlCommand("delete from payments where vendername='"+vendernamevalu.Text+"' AND voucherno='"+vouchernumbervalue.Text+"' AND chequeno='"+chequenovalue.Text+"' AND bankaccount='"+bankaccountvalue.Text+"' AND ipsc='"+ipscvalue.Text+"' AND invoiceno='"+invoicenumbervalue.Text+"' AND amount='"+amountvalue.Text+"' ", con);
                sc.ExecuteNonQuery();
              MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException )
            {
                MessageBox.Show("PLEASE CONTACT THE PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                vendernamevalu.Text = selectedRow.Cells[0].Value.ToString();
                totalvaluetext.Text = selectedRow.Cells[1].Value.ToString();
                PAYOPTIONVALUE.Text = selectedRow.Cells[2].Value.ToString();
                paymentdescrptionvalue.Text = selectedRow.Cells[3].Value.ToString();
                banknamevalue.Text = selectedRow.Cells[4].Value.ToString();
                bankaccountvalue.Text = selectedRow.Cells[5].Value.ToString();
                ipscvalue.Text = selectedRow.Cells[6].Value.ToString();
                chequenovalue.Text = selectedRow.Cells[7].Value.ToString();
                chequedatevalue.Text = selectedRow.Cells[8].Value.ToString();
                vouchernumbervalue.Text = selectedRow.Cells[9].Value.ToString();
                datevalue.Text = selectedRow.Cells[10].Value.ToString();
                invoicenumbervalue.Text = selectedRow.Cells[11].Value.ToString();
                discountvalue.Text = selectedRow.Cells[12].Value.ToString();
                amountvalue.Text = selectedRow.Cells[13].Value.ToString(); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Select only one cell OR contact person");
            }
        }

        private void payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet5.venderdetails' table. You can move, or remove it, as needed.
            this.venderdetailsTableAdapter.Fill(this.masterDataSet5.venderdetails);
            // TODO: This line of code loads data into the 'masterDataSet7.venderdetails' table. You can move, or remove it, as needed.
            //this.venderdetailsTableAdapter.Fill(this.masterDataSet7.venderdetails);
            // TODO: This line of code loads data into the 'masterDataSet6.purchaseentry' table. You can move, or remove it, as needed.
            //this.purchaseentryTableAdapter.Fill(this.masterDataSet6.purchaseentry);
            disp_data();








        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from payments";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
