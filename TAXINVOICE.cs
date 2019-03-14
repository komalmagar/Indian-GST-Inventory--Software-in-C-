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
    public partial class TAXINVOICE : Form
    {
        public TAXINVOICE( )
        {
            InitializeComponent();
            

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=true");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datedate_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("WANT TO DELETE FROM STOCKS AND reduce Credits But Stocks Must Not less than 0 Check first?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmda, cmda1, cmda2;
                    cmda = new SqlCommand("update stocks set quantity=quantity+'" + textBox3.Text + "'", con);
                    cmda.ExecuteNonQuery();
                    cmda1 = new SqlCommand("update stocks set freeqty=freeqty+'" + textBox4.Text + "'", con);
                    cmda1.ExecuteNonQuery();
                    cmda2 = new SqlCommand("update MONEYBANK set creditmoney=creditmoney-'" + textBox7.Text + "'", con);
                    cmda2.ExecuteNonQuery();
                    SqlCommand sc = new SqlCommand("delete from taxinvoice where  toname='" + comboBox1.Text + "'  AND  address='" + comboBox4.Text + "'  AND  area='" + comboBox3.Text + "'  AND   cash='" + comboBox6.Text + "'  AND  totalqty='" + textBox1.Text + "'  AND  free='" + textBox2.Text + "'  AND  invoiceno='" + invoicenoval.Text + "'  AND  invoicedate='" + dateTimePicker1.Text + "'  AND  productname='" + comboBox2.Text + "'  AND   prcode='" + comboBox5.Text + "'  AND  ratevalue='" + textBox3.Text + "'  AND quantity='" + textBox4.Text + "'", con);
                    sc.ExecuteNonQuery();


                }

                else
                {
                    SqlCommand s1c = new SqlCommand("delete from taxinvoice where  toname='" + comboBox1.Text + "'  AND  address='" + comboBox4.Text + "'  AND  area='" + comboBox3.Text + "'  AND   cash='" + comboBox6.Text + "'  AND  totalqty='" + textBox1.Text + "'  AND  free='" + textBox2.Text + "'  AND  invoiceno='" + invoicenoval.Text + "'  AND  invoicedate='" + dateTimePicker1.Text + "'  AND  productname='" + comboBox2.Text + "'  AND   prcode='" + comboBox5.Text + "'  AND  ratevalue='" + textBox3.Text + "'  AND quantity='" + textBox4.Text + "'", con);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string strDecVal
        {
            set { comboBox1.Text = value; }
        }


        private void taxinvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.masterDataSet.product);
            // TODO: This line of code loads data into the 'customer1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customer1.customer);
            // TODO: This line of code loads data into the 'masterDataSet5.customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter1.Fill(this.masterDataSet5.customer);
            // TODO: This line of code loads data into the 'masterDataSet4.product' table. You can move, or remove it, as needed.
           // this.productTableAdapter.Fill(this.masterDataSet4.product);
            // TODO: This line of code loads data into the 'masterDataSet3.customer' table. You can move, or remove it, as needed.
           // this.customerTableAdapter.Fill(this.masterDataSet3.customer);
            // disp_data();

        }
        public void disp_data()
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView1.ColumnCount - 1;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from taxinvoice";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR TO SHOW DATA CONTACT A PERSON", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //for applied tax;;;;;;;;;;;;;;;;;;;;;;;
                SqlDataAdapter asdf3 = new SqlDataAdapter("select saletax  from product where productname='" + comboBox2.Text + "'", con);
                DataTable ss3 = new DataTable();
                asdf3.Fill(ss3);
                textBox13.Text = ss3.Rows[0][0].ToString();


                Int64 quantity = Convert.ToInt64(textBox4.Text);
                Int64 totalqty = Convert.ToInt64(textBox1.Text);
                if (quantity > totalqty)
                {
                    MessageBox.Show("Please enter less OR equal value of TOTALQty");
                }
                else
                {

                    SqlDataAdapter asdf10 = new SqlDataAdapter("select quantity from stocks where prcode='" + comboBox5.Text + "'", con);
                    DataTable ss10 = new DataTable();
                    asdf10.Fill(ss10);
                    textBox1.Text = ss10.Rows[0][0].ToString();
                    SqlDataAdapter asdf500 = new SqlDataAdapter("select freeqty from stocks where prcode='" + comboBox5.Text + "'", con);
                    DataTable ss500 = new DataTable();
                    asdf500.Fill(ss500);
                    textBox2.Text = ss500.Rows[0][0].ToString();

                    //for the value calculation
                    double appliedtax, ratevalue, quantityval, rateandquant, discountval1, freeqty, subofall, subdisc, finalval, fordisc, gstcal, totalvalue;
                    discountval1 = Convert.ToDouble(caldis.Text);
                    freeqty = Convert.ToDouble(textBox5.Text);
                    appliedtax = Convert.ToDouble(textBox13.Text);
                    ratevalue = Convert.ToDouble(textBox3.Text);
                    quantityval = Convert.ToDouble(textBox4.Text);
                    subofall = freeqty + quantityval;
                    finalval = subofall * ratevalue;
                    subdisc = (discountval1 / 100) * finalval;
                    fordisc = finalval - subdisc;
                    rateandquant = finalval + (finalval * appliedtax / 100);
                    totalvalue = rateandquant - subdisc;
                    gstcal = rateandquant - fordisc;
                    int refersale;
                    refersale = Convert.ToInt16(this.textBox13.Text);
                    if (refersale == 0)
                    {
                        textBox12.Text = refersale.ToString();
                        int mtextbox12 = Convert.ToInt16(this.textBox12.Text);
                        textBox8.Clear();
                        textBox9.Clear();
                        textBox10.Clear();
                        textBox11.Clear();
                        textBox6.Text = rateandquant.ToString();
                        textBox25.Clear();
                        textBox24.Clear();
                        textBox22.Clear();
                        textBox23.Clear();
                    }
                    else if (refersale == 5)
                    {
                        textBox8.Text = refersale.ToString();
                        int mtextbox8 = Convert.ToInt16(this.textBox8.Text);
                        textBox9.Clear();
                        textBox10.Clear();
                        textBox11.Clear();
                        textBox12.Clear();
                        textBox25.Text = rateandquant.ToString();
                        textBox6.Clear();
                        textBox24.Clear();
                        textBox22.Clear();
                        textBox23.Clear();
                    }
                    else if (refersale == 12)
                    {
                        textBox9.Text = refersale.ToString();
                        int mtextbox9 = Convert.ToInt16(this.textBox9.Text);
                        textBox10.Clear();
                        textBox11.Clear();
                        textBox12.Clear();
                        textBox8.Clear();
                        textBox24.Text = rateandquant.ToString();
                        textBox25.Clear();
                        textBox6.Clear();
                        textBox22.Clear();
                        textBox23.Clear();

                    }
                    else if (refersale == 18)
                    {
                        textBox10.Text = refersale.ToString();
                        int mtextbox10 = Convert.ToInt16(this.textBox10.Text);
                        textBox9.Clear();
                        textBox11.Clear();
                        textBox12.Clear();
                        textBox8.Clear();
                        textBox23.Text = rateandquant.ToString();
                        textBox25.Clear();
                        textBox6.Clear();
                        textBox22.Clear();
                        textBox24.Clear();
                    }
                    else if (refersale == 28)
                    {
                        textBox11.Text = refersale.ToString();
                        int mtextbox11 = Convert.ToInt16(this.textBox11.Text);
                        textBox9.Clear();
                        textBox10.Clear();
                        textBox12.Clear();
                        textBox8.Clear();
                        textBox22.Text = rateandquant.ToString();
                        textBox25.Clear();
                        textBox6.Clear();
                        textBox24.Clear();
                        textBox23.Clear();
                    }
                    subtotalval.Text = finalval.ToString();
                    discvalu.Text = subdisc.ToString();
                    afterdiscval.Text = fordisc.ToString();
                    gsttotalval.Text = gstcal.ToString();
                    textBox7.Text = totalvalue.ToString();

                    string igst;
                    igst = comboBox7.SelectedItem.ToString();
                    if (igst == "Y")
                    {
                        igstval.Text = gstcal.ToString();
                        cgstval.Clear();
                        sgstval.Clear();
                    }
                    else
                    {
                        double divide;
                        divide = gstcal / 2;
                        cgstval.Text = divide.ToString();
                        sgstval.Text = divide.ToString();
                        igstval.Clear();

                    }

                    SqlCommand cm;
                    cm = new SqlCommand("update MONEYBANK set creditmoney=creditmoney+'" + totalvalue.ToString()+ "'", con);
                    cm.ExecuteNonQuery();
                    String query100 = "select *  from  MONEYBANK";
                    SqlCommand cmd100 = new SqlCommand(query100, con);
                    SqlDataReader dr = cmd100.ExecuteReader();

                    if (dr.Read())
                    {
                        creditval.Text = (dr["creditmoney"].ToString());
                        debitvaltaxvoice.Text = (dr["debitmoney"].ToString());

                    }
                    String query = "insert into taxinvoice (toname,address,area,cash,totalqty,free,invoiceno,invoicedate,productname,prcode,ratevalue,quantity,freeqty,discount,subtotal,discvalue,aftervalue,credit,debit,gsttotal,cgst,sgst,igst,totalvalue,value0,value5,value12,value18,value28,tax0,tax5,tax12,tax18,tax28,igstval) values ('" + comboBox1.Text + "','" + comboBox4.Text + "','" + comboBox3.Text + "','" + comboBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + invoicenoval.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + comboBox5.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + caldis.Text + "','" + subtotalval.Text + "','" + discvalu.Text + "','" + afterdiscval.Text + "','" + creditval.Text + "','" + debitvaltaxvoice.Text + "','" + gsttotalval.Text + "','" + cgstval.Text + "','" + sgstval.Text + "','" + igstval.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox25.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "','" + textBox12.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox7.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ////for stocks
                    SqlCommand cmd, cmd1;
                    SqlCommand cmda, cmda1;
                    SqlDataAdapter da = new SqlDataAdapter("select  * from stocks where prcode='" + comboBox5.Text + "' ", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);



                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        cmda = new SqlCommand("update stocks set quantity=quantity-'" + textBox4.Text + "'", con);
                        cmda.ExecuteNonQuery();
                        cmda1 = new SqlCommand("update stocks set freeqty=freeqty-'" + textBox5.Text + "'", con);
                        cmda1.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("BYE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                } 
                          
            
            }
        
            catch (Exception)
            {
                MessageBox.Show("CLoseing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }


        }

        private void cgstval_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select *  from taxinvoice";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                comboBox1.Text = selectedRow.Cells[0].Value.ToString();
                comboBox4.Text = selectedRow.Cells[1].Value.ToString();
                comboBox3.Text = selectedRow.Cells[2].Value.ToString();
                comboBox6.Text = selectedRow.Cells[3].Value.ToString();
                textBox1.Text = selectedRow.Cells[4].Value.ToString();
                textBox2.Text = selectedRow.Cells[5].Value.ToString();
                invoicenoval.Text = selectedRow.Cells[6].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells[7].Value.ToString();
                comboBox2.Text = selectedRow.Cells[8].Value.ToString();
                comboBox5.Text = selectedRow.Cells[9].Value.ToString();
                textBox3.Text = selectedRow.Cells[10].Value.ToString();
                textBox4.Text = selectedRow.Cells[11].Value.ToString();
                caldis.Text = selectedRow.Cells[12].Value.ToString();
                subtotalval.Text = selectedRow.Cells[13].Value.ToString();
                discvalu.Text = selectedRow.Cells[14].Value.ToString();
                afterdiscval.Text = selectedRow.Cells[15].Value.ToString();
                creditval.Text = "0.0";
                debitvaltaxvoice.Text = "0.0";
                gsttotalval.Text = selectedRow.Cells[18].Value.ToString();
                cgstval.Text = selectedRow.Cells[19].Value.ToString();
                sgstval.Text = selectedRow.Cells[20].Value.ToString();
                igstval.Text = selectedRow.Cells[21].Value.ToString();
                textBox7.Text = selectedRow.Cells[22].Value.ToString();
                textBox6.Text = selectedRow.Cells[23].Value.ToString();
                textBox25.Text = selectedRow.Cells[24].Value.ToString();
                textBox24.Text = selectedRow.Cells[25].Value.ToString();
                textBox23.Text = selectedRow.Cells[26].Value.ToString();
                textBox22.Text = selectedRow.Cells[27].Value.ToString();
                textBox12.Text = selectedRow.Cells[28].Value.ToString();
                textBox8.Text = selectedRow.Cells[29].Value.ToString();
                textBox9.Text = selectedRow.Cells[30].Value.ToString();
                textBox10.Text = selectedRow.Cells[31].Value.ToString();
                textBox11.Text = selectedRow.Cells[32].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select one at a time only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                textBox1.Clear();
                textBox2.Clear();
                String query1 = "select *  from stocks where prcode='" + comboBox5.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                if (dr1.Read())
                {

                    textBox1.Text = (dr1["quantity"].ToString());
                    textBox2.Text = (dr1["freeqty"].ToString());
                }
                String query = "select *  from purchaseentry where productname='" + comboBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textBox3.Text = (dr["sellprice"].ToString());
                    invoicenoval.Text = (dr["invoiceno"].ToString());
                    comboBox5.Text = (dr["prcode"].ToString());

                }
                else
                {
                    textBox3.Clear();
                    invoicenoval.Clear();
                }
                con.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("No Any Data to Show", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
              
            }


        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("DO YOU WANT TO Update The STOCKS?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialog == DialogResult.Yes)
                {
                    string a = textBox4.Text.ToString();
                    string fr = textBox5.Text.ToString();
                    String query = "select *  from taxinvoice where toname='" + comboBox1.Text + "'  AND  address='" + comboBox4.Text + "'  AND  area='" + comboBox3.Text + "'  AND   cash='" + comboBox6.Text + "'  AND  totalqty='" + textBox1.Text + "'  AND  free='" + textBox2.Text + "'  AND  invoiceno='" + invoicenoval.Text + "'  AND  invoicedate='" + dateTimePicker1.Text + "'  AND  productname='" + comboBox2.Text + "'  AND   prcode='" + comboBox5.Text + "'  AND  ratevalue='" + textBox3.Text + "'  AND quantity='" + textBox4.Text + "'";
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
                            cmda = new SqlCommand("update stocks set quantity=quantity+'" + p + "'", con);
                            cmda.ExecuteNonQuery();
                        }
                        else
                        {
                            int p = l - m;
                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set quantity=quantity-'" + p + "'", con);
                            cmda.ExecuteNonQuery();

                        }
                        if (forfree < nsfree)
                        {
                            int p = nsfree - forfree;

                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set freeqty=freeqty+'" + p + "'", con);
                            cmda.ExecuteNonQuery();
                        }
                        else
                        {

                            int p = forfree - nsfree;
                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set freeqty=freeqty-'" + p + "'", con);
                            cmda.ExecuteNonQuery();
                        }
                    
            

                

                        SqlCommand sc1 = new SqlCommand();
                        sc1.CommandText = @"update taxinvoice set  address='" + comboBox4.Text + "'  ,  area='" + comboBox3.Text + "'  ,  cash='" + comboBox6.Text + "'  ,  totalqty='" + textBox1.Text + "'  ,  free='" + textBox2.Text + "'   ,  invoicedate='" + dateTimePicker1.Text + "'  ,  productname='" + comboBox2.Text + "'  ,   prcode='" + comboBox5.Text + "'  ,  ratevalue='" + textBox3.Text + "'  , quantity='" + textBox4.Text + "' ,freeqty='" + textBox5.Text + "' ,discount='" + caldis.Text + "',tax0='" + textBox12.Text + "',tax5='" + textBox8.Text + "',tax12='" + textBox9.Text + "',tax18='" + textBox10.Text + "',tax28='" + textBox11.Text + "',value0='" + textBox6.Text + "' ,value5='" + textBox25.Text + "' ,value12='" + textBox24.Text + "' ,value18='" + textBox23.Text + "' ,value28='" + textBox22.Text + "', Subtotal='" + subtotalval.Text + "' ,discvalue='" + discvalu.Text + "' ,aftervalue='" + afterdiscval.Text + "' ,credit='" + creditval.Text + "' , debit='" + debitvaltaxvoice.Text + "',gsttotal='" + gsttotalval.Text + "',CGST='" + cgstval.Text + "' ,SGST='" + sgstval.Text + "' ,IGST='" + igstval.Text + "',totalvalue='" + textBox7.Text + "' ,igstval='" + comboBox7.Text + "' where  toname='" + comboBox1.Text + "' AND invoiceno='" + invoicenoval.Text + "' ";
                        sc1.Connection = con;
                        sc1.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.Refresh();
                    }
            
                }
                else
                {
                    SqlCommand sc = new SqlCommand();
                    sc.CommandText = @"update taxinvoice set  address='" + comboBox4.Text + "'  ,  area='" + comboBox3.Text + "'  ,  cash='" + comboBox6.Text + "'  ,  totalqty='" + textBox1.Text + "'  ,  free='" + textBox2.Text + "'   ,  invoicedate='" + dateTimePicker1.Text + "'  ,  productname='" + comboBox2.Text + "'  ,   prcode='" + comboBox5.Text + "'  ,  ratevalue='" + textBox3.Text + "'  , quantity='" + textBox4.Text + "' ,freeqty='" + textBox5.Text + "' ,discount='" + caldis.Text + "',tax0='" + textBox12.Text + "',tax5='" + textBox8.Text + "',tax12='" + textBox9.Text + "',tax18='" + textBox10.Text + "',tax28='" + textBox11.Text + "',value0='" + textBox6.Text + "' ,value5='" + textBox25.Text + "' ,value12='" + textBox24.Text + "' ,value18='" + textBox23.Text + "' ,value28='" + textBox22.Text + "', Subtotal='" + subtotalval.Text + "' ,discvalue='" + discvalu.Text + "' ,aftervalue='" + afterdiscval.Text + "' ,credit='" + creditval.Text + "' , debit='" + debitvaltaxvoice.Text + "',gsttotal='" + gsttotalval.Text + "',CGST='" + cgstval.Text + "' ,SGST='" + sgstval.Text + "' ,IGST='" + igstval.Text + "',totalvalue='" + textBox7.Text + "',igstval='" + comboBox7.Text + "'  where  toname='" + comboBox1.Text + "' AND invoiceno='" + invoicenoval.Text + "' ";
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

        public void button2_Click(object sender, EventArgs e)
        {
            
            DEFAULTPRINTER dp = new DEFAULTPRINTER();
            dp.ShowDialog();
            
           
        }

        private void button2_Click()
        {
            DEFAULTPRINTER dp = new DEFAULTPRINTER();
            dp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Standard st = new Standard();
            st.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyPrint mp = new MyPrint();
            mp.Show();
        }
}




    }



