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
    public partial class SalesReturn : Form
    {
        public SalesReturn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");
        private void SalesReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet2.product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.masterDataSet2.product);
            // TODO: This line of code loads data into the 'masterDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.masterDataSet2.customer);
            // TODO: This line of code loads data into the 'masterDataSet10.purchaseentry' table. You can move, or remove it, as needed.
           // this.purchaseentryTableAdapter.Fill(this.masterDataSet10.purchaseentry);
            // TODO: This line of code loads data into the 'productname.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productname.product);
            // TODO: This line of code loads data into the 'masterDataSet9.customer' table. You can move, or remove it, as needed.
            ///this.customerTableAdapter.Fill(this.masterDataSet9.customer);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select *  from customer where customername='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["address"].ToString();
                    textBox2.Text = dr["taluka"].ToString();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("NO DATA", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally {
                con.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select *  from  purchaseentry where productname='" + comboBox3.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox4.Text = dr["prcode"].ToString();
                    textBox7.Text = dr["sellprice"].ToString();


                }

            }
            catch (Exception)
            {
                MessageBox.Show("NO DATA", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close(); 
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            
                


        }

        private void button1_Click(object sender, EventArgs e)
        {
         //for the value calculation
            try
            {
                con.Open();
                SqlDataAdapter asdf3 = new SqlDataAdapter("select saletax  from product where productname='" + comboBox3.Text + "'", con);
                DataTable ss3 = new DataTable();
                asdf3.Fill(ss3);
                textBox30.Text = ss3.Rows[0][0].ToString();
                double appliedtax, ratevalue, quantityval, rateandquant, discountval1, freeqty, subofall, subdisc, finalval, fordisc, gstcal, totalvalue;
                discountval1 = Convert.ToDouble(textBox10.Text);
                freeqty = Convert.ToDouble(textBox9.Text);
                appliedtax = Convert.ToDouble(textBox30.Text);
                ratevalue = Convert.ToDouble(textBox7.Text);
                quantityval = Convert.ToDouble(textBox8.Text);
                subofall = freeqty + quantityval;
                finalval = subofall * ratevalue;
                subdisc = (discountval1 / 100) * finalval;
                fordisc = finalval - subdisc;
                rateandquant = finalval + (finalval * appliedtax / 100);
                totalvalue = rateandquant - subdisc;
                gstcal = rateandquant - fordisc;
                int refersale;
                refersale = Convert.ToInt16(this.textBox30.Text);
                if (refersale == 0)
                {
                    textBox29.Text = refersale.ToString();
                    int mtextbox12 = Convert.ToInt16(this.textBox29.Text);
                    textBox11.Clear();
                    textBox26.Clear();
                    textBox27.Clear();
                    textBox28.Clear();
                    textBox6.Text = rateandquant.ToString();
                    textBox25.Clear();
                    textBox24.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                }
                else if (refersale == 5)
                {
                    textBox11.Text = refersale.ToString();
                    int mtextbox8 = Convert.ToInt16(this.textBox11.Text);
                    textBox29.Clear();

                    textBox25.Text = rateandquant.ToString();
                    textBox6.Clear();
                    textBox24.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox26.Clear();
                    textBox27.Clear();
                    textBox28.Clear();
                }
                else if (refersale == 12)
                {
                    textBox26.Text = refersale.ToString();
                    int mtextbox9 = Convert.ToInt16(this.textBox26.Text);
                    textBox11.Clear();
                    textBox24.Text = rateandquant.ToString();
                    textBox25.Clear();
                    textBox6.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox29.Clear();
                    textBox27.Clear();
                    textBox28.Clear();

                }
                else if (refersale == 18)
                {
                    textBox27.Text = refersale.ToString();
                    int mtextbox10 = Convert.ToInt16(this.textBox27.Text);
                    textBox11.Clear();
                    textBox23.Text = rateandquant.ToString();
                    textBox25.Clear();
                    textBox6.Clear();
                    textBox22.Clear();

                    textBox29.Clear();
                    textBox26.Clear();
                    textBox24.Clear();
                    textBox28.Clear();
                }
                else if (refersale == 28)
                {
                    textBox28.Text = refersale.ToString();
                    int mtextbox11 = Convert.ToInt16(this.textBox28.Text);
                    textBox11.Clear();
                    textBox22.Text = rateandquant.ToString();
                    textBox25.Clear();
                    textBox6.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox29.Clear();
                    textBox26.Clear();
                    textBox27.Clear();
                }
                textBox21.Text = finalval.ToString();
                textBox20.Text = subdisc.ToString();
                textBox19.Text = fordisc.ToString();
                textBox16.Text = gstcal.ToString();
                textBox12.Text = totalvalue.ToString();
                SqlDataAdapter asdf11 = new SqlDataAdapter("select igst  from customer where customername='" + comboBox1.Text + "' ", con);
                DataTable ss11 = new DataTable();
                asdf11.Fill(ss11);
                string igst;
                igst = ss11.Rows[0][0].ToString();
                if (igst == "YES")
                {
                    textBox13.Text = gstcal.ToString();
                    textBox15.Clear();
                    textBox14.Clear();
                }
                else
                {
                    double divide;
                    divide = gstcal / 2;
                    textBox15.Text = divide.ToString();
                    textBox14.Text = divide.ToString();
                    textBox13.Clear();

                }
                /*
                SqlCommand cm;
                cm = new SqlCommand("update MONEYBANK set creditmoney=creditmoney-'" + totalvalue.ToString() + "'", con);
                cm.ExecuteNonQuery();
                String query100 = "select *  from  MONEYBANK";
                SqlCommand cmd100 = new SqlCommand(query100, con);
                SqlDataReader dr = cmd100.ExecuteReader();

                if (dr.Read())
                {
                    creditval.Text = (dr["creditmoney"].ToString());
                    debitvaltaxvoice.Text = (dr["debitmoney"].ToString());

                }*/



                String query = "insert into salesreturn (fromcustomer,address,area,returntype,checkinvoice,checkbatch,returnno,returndate,productname,prcode,ratevalue,quantity,freeqty,discount,subtotal,discval,afterdisc,credit,debit,gsttotal,cgst,sgst,igst,totalvalue,value0,value5,value12,value18,value28,tax0,tax5,tax12,tax18,tax28) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox21.Text + "','" + textBox20.Text + "','" + textBox19.Text + "','" + textBox18.Text + "','" + textBox17.Text + "','" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox12.Text + "','" + textBox6.Text + "','" + textBox25.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "','" + textBox29.Text + "','" + textBox11.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + textBox28.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ////for stocksssssssssssssssss


                SqlCommand cmd, cmd1;
                SqlCommand cmda, cmda1;

                SqlDataAdapter da = new SqlDataAdapter("select  * from stocks where prcode='" + comboBox4.Text + "' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);



                if (ds.Tables[0].Rows.Count > 0)
                {

                    cmda = new SqlCommand("update stocks set quantity=quantity+'" + textBox8.Text + "'", con);
                    cmda.ExecuteNonQuery();
                    cmda1 = new SqlCommand("update stocks set freeqty=freeqty+'" + textBox9.Text + "'", con);
                    cmda1.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fill All DATA", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from salesreturn";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            
            }
            catch (Exception )
            {
                MessageBox.Show("PLEASE FILL DATA FIRST OR PLEASE CONTACT THE PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                comboBox1.Text = selectedRow.Cells[0].Value.ToString();
                textBox1.Text = selectedRow.Cells[1].Value.ToString();
                textBox2.Text = selectedRow.Cells[2].Value.ToString();
                comboBox2.Text = selectedRow.Cells[3].Value.ToString();
                textBox3.Text = selectedRow.Cells[4].Value.ToString();
                textBox4.Text = selectedRow.Cells[5].Value.ToString();
                textBox5.Text = selectedRow.Cells[6].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells[7].Value.ToString();
                comboBox3.Text = selectedRow.Cells[8].Value.ToString();
                comboBox4.Text = selectedRow.Cells[9].Value.ToString();
                textBox7.Text = selectedRow.Cells[10].Value.ToString();
                textBox8.Text = selectedRow.Cells[11].Value.ToString();
                textBox9.Text = selectedRow.Cells[12].Value.ToString();
                textBox10.Text = selectedRow.Cells[13].Value.ToString();
                textBox21.Text = selectedRow.Cells[14].Value.ToString();
                textBox19.Text = selectedRow.Cells[15].Value.ToString();
                textBox18.Text = selectedRow.Cells[16].Value.ToString();
                textBox17.Text = selectedRow.Cells[17].Value.ToString();
                textBox16.Text = selectedRow.Cells[18].Value.ToString();
                textBox15.Text = selectedRow.Cells[19].Value.ToString();
                textBox14.Text = selectedRow.Cells[20].Value.ToString();
                textBox13.Text = selectedRow.Cells[21].Value.ToString();
                textBox12.Text = selectedRow.Cells[22].Value.ToString();
                textBox6.Text = selectedRow.Cells[23].Value.ToString();
                textBox25.Text = selectedRow.Cells[24].Value.ToString();
                textBox24.Text = selectedRow.Cells[25].Value.ToString();
                textBox23.Text = selectedRow.Cells[26].Value.ToString();
                textBox22.Text = selectedRow.Cells[27].Value.ToString();
                textBox29.Text = selectedRow.Cells[28].Value.ToString();
                textBox11.Text = selectedRow.Cells[29].Value.ToString();
                textBox26.Text = selectedRow.Cells[30].Value.ToString();
                textBox27.Text = selectedRow.Cells[31].Value.ToString();
                textBox28.Text = selectedRow.Cells[32].Value.ToString();
                
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
                con.Open();
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("WANT TO DELETE FROM STOCKS But Stocks Must Not less than 0 Check first?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (dialog == DialogResult.Yes)
                {


                    SqlCommand cmda, cmda1;
                    cmda = new SqlCommand("update stocks set quantity=quantity-'" + textBox8.Text + "'", con);
                    cmda.ExecuteNonQuery();
                    cmda1 = new SqlCommand("update stocks set freeqty=freeqty-'" + textBox9.Text + "'", con);
                    cmda1.ExecuteNonQuery();
                    SqlCommand sc = new SqlCommand("delete from salesreturn where  fromcustomer='" + comboBox1.Text + "' AND productname='" + comboBox3.Text + "'  AND quantity='"+textBox8.Text+"' AND returnno='"+textBox5.Text+"' ", con);
                    sc.ExecuteNonQuery();

                }
                else
                {
                    SqlCommand s1c = new SqlCommand("delete from salesreturn where  fromcustomer='" + comboBox1.Text + "' AND productname='" + comboBox3.Text + "'  AND quantity='"+textBox8.Text+"' AND returnno='"+textBox5.Text+"'", con);
                    s1c.ExecuteNonQuery();
                }

                MessageBox.Show("Record deleted successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            catch (SqlException ex)
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
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("DO YOU WANT TO Update The STOCKS?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialog == DialogResult.Yes)
                {
                    string a = textBox8.Text.ToString();
                    string fr = textBox9.Text.ToString();
                    String query = "select *  from salesreturn where ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string b, myfree;
                        b = (dr["quantity"].ToString());
                        myfree = (dr["freeqty"].ToString());
                        int l, m, forfree, nsfree;
                        l = Convert.ToInt16(a.ToString());
                        m = Convert.ToInt16(b.ToString());
                        forfree = Convert.ToInt16(fr.ToString());
                        nsfree = Convert.ToInt16(myfree.ToString());
                        if (l < m)
                        {
                            int p = m - l;

                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set quantity=quantity-'" + p + "'", con);
                            cmda.ExecuteNonQuery();
                        }
                        else
                        {
                            int p = l - m;
                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set quantity=quantity+'" + p + "'", con);
                            cmda.ExecuteNonQuery();

                        }
                        if (forfree < nsfree)
                        {
                            int p = nsfree - forfree;

                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set freeqty=freeqty-'" + p + "'", con);
                            cmda.ExecuteNonQuery();
                        }
                        else
                        {

                            int p = forfree - nsfree;
                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set freeqty=freeqty+'" + p + "'", con);
                            cmda.ExecuteNonQuery();
                        }
                    }
                    SqlCommand sc1 = new SqlCommand();
                    sc1.CommandText = @"update purchaseentry set  returntype='" + comboBox2.Text + "' , checkinvoice='" + textBox3.Text + "' , checkbatch='" + textBox4.Text + "' , returndate='" + dateTimePicker1.Text + "' , productname='" + comboBox3.Text + "' ,prcode='" + comboBox4.Text + "' , ratevalue='" + textBox7.Text + "' , quantity='" + textBox8.Text + "' , freeqty='" + textBox9.Text + "' , discount='" + textBox10.Text + "' , subtotal='" + textBox21.Text + "' , discval='" + textBox20.Text + "' , afterdisc='" + textBox19.Text + "' , credit='" + textBox18.Text + "' , debit='" + textBox17.Text + "' ,gsttotal='" + textBox16.Text + "' , cgst='" + textBox15.Text + "' ,sgst='" + textBox14.Text + "' , igst='" + textBox13.Text + "',totalvalue='" + textBox12.Text + "' , value0='" + textBox6.Text + "' ,value5='" + textBox25.Text + "' ,value12='" + textBox24.Text + "' ,value18='" + textBox23.Text + "',value28='" + textBox22.Text + "' ,tax0='" + textBox29.Text + "',tax5='" + textBox11.Text + "',tax12='" + textBox26.Text + "',tax18='" + textBox27.Text + "',tax28='" + textBox28.Text + "'  where fromcustomer='" + comboBox1.Text + "' AND , returnno='" + textBox5.Text + "'  ";
                    sc1.Connection = con;
                    sc1.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.Refresh();
                }
                else
                {
                    SqlCommand sc = new SqlCommand();
                    sc.CommandText = @"update purchaseentry set  returntype='" + comboBox2.Text + "' , checkinvoice='" + textBox3.Text + "' , checkbatch='" + textBox4.Text + "' , returndate='" + dateTimePicker1.Text + "' , productname='" + comboBox3.Text + "' ,prcode='" + comboBox4.Text + "' , ratevalue='" + textBox7.Text + "' , quantity='" + textBox8.Text + "' , freeqty='" + textBox9.Text + "' , discount='" + textBox10.Text + "' , subtotal='" + textBox21.Text + "' , discval='" + textBox20.Text + "' , afterdisc='" + textBox19.Text + "' , credit='" + textBox18.Text + "' , debit='" + textBox17.Text + "' ,gsttotal='" + textBox16.Text + "' , cgst='" + textBox15.Text + "' ,sgst='" + textBox14.Text + "' , igst='" + textBox13.Text + "',totalvalue='" + textBox12.Text + "' , value0='" + textBox6.Text + "' ,value5='" + textBox25.Text + "' ,value12='" + textBox24.Text + "' ,value18='" + textBox23.Text + "',value28='" + textBox22.Text + "' ,tax0='" + textBox29.Text + "',tax5='" + textBox11.Text + "',tax12='" + textBox26.Text + "',tax18='" + textBox27.Text + "',tax28='" + textBox28.Text + "'  where fromcustomer='" + comboBox1.Text + "' AND , returnno='" + textBox5.Text + "'  ";
                    sc.Connection = con;
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.Refresh();
                }

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
