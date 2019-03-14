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
    public partial class AddVendors : Form
    {
        private string mstrClsTitle = "";
        public AddVendors()
        {
            InitializeComponent();
            this.FormClosing += AddVendors_FormClosing;

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=true");


        private void productname_Click(object sender, EventArgs e)
        {

        }

        private void AddVendors_Load(object sender, EventArgs e)
        {
            con.Open();

            // TODO: This line of code loads data into the 'product.product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.product.product);
            // TODO: This line of code loads data into the 'masterDataSet4.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.masterDataSet4.product);
            // TODO: This line of code loads data into the 'masterDataSet3.venderdetails' table. You can move, or remove it, as needed.
            this.venderdetailsTableAdapter.Fill(this.masterDataSet3.venderdetails);
            //disp_data();
            // TODO: This line of code loads data into the 'masterDataSet2.venderdetails' table. You can move, or remove it, as needed.
            //this.venderdetailsTableAdapter.Fill(this.masterDataSet2.venderdetails);
            // TODO: This line of code loads data into the 'masterDataSet1.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.masterDataSet1.product);
            // TODO: This line of code loads data into the 'masterDataSet.product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.masterDataSet.product);
            con.Close();

        }

        private void venderval_TextChanged(object sender, EventArgs e)
        {

        }
        string n;
        private void submit_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                //for applied tax;;;;;;;;;;;;;;;;;;;;;;;
                SqlDataAdapter asdf3 = new SqlDataAdapter("select saletax  from product where productname='" + comboBox2.Text + "'", con);
                DataTable ss3 = new DataTable();
                asdf3.Fill(ss3);
                textBox13.Text = ss3.Rows[0][0].ToString();
                double appliedtax, ratevalue, quantityval1, rateandquant, discountval1, freeqty, subofall, subdisc, finalval, fordisc, gstcal, totalvalue;
                discountval1 = Convert.ToDouble(discountval.Text);
                freeqty = Convert.ToDouble(freeqtyvalu.Text);
                appliedtax = Convert.ToDouble(textBox13.Text);
                ratevalue = Convert.ToDouble(sellpriceval.Text);
                quantityval1 = Convert.ToDouble(quantityval.Text);
                subofall = freeqty + quantityval1;
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
                igst = comboBox4.SelectedItem.ToString();
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

                if (comboBox3.Text == " " || invoicenoval.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || batchval.Text == "")
                {

                    MessageBox.Show("Please  enter All DATA");


                }
                else
                {


                    String query = "insert into purchaseentry (vendor,invoiceno,cash,prcode,perprice,sellprice,mrp,optprice,tax,invoicedate,receiveddate,lrdate,productname,batch,expdate,quantity,freeqty,discount,tax0,tax5,tax12,tax18,tax28,val0,val5,val12,val18,val28,Subtotal,discval,afterdisc,credit,debit,gsttotal,CGST,SGST,IGST,totalvalue) values ('" + comboBox3.Text + "','" + invoicenoval.Text + "','" + domainUpDown1.Text + "','" + comboBox1.Text + "','" + purpriceval.Text + "','" + sellpriceval.Text + "','" + mrpval.Text + "','" + optpriceval.Text + "','" + taxval.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "','" + comboBox2.Text + "','" + batchval.Text + "','" + dateTimePicker4.Text + "','" + quantityval.Text + "','" + freeqtyvalu.Text + "','" + discountval.Text + "','" + textBox12.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox6.Text + "','" + textBox25.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "','" + subtotalval.Text + "','" + discvalu.Text + "','" + afterdiscval.Text + "','" + creditval.Text + "','" + debitvaltaxvoice.Text + "','" + gsttotalval.Text + "','" + cgstval.Text + "','" + sgstval.Text + "','" + igstval.Text + "','" + textBox7.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                ///////////for stocks/////
                SqlCommand cmd, cmd1;
                SqlCommand cmda, cmda1;

                SqlDataAdapter da = new SqlDataAdapter("select  * from stocks where prcode='" + comboBox1.Text + "' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);



                if (ds.Tables[0].Rows.Count > 0)
                {

                    cmda = new SqlCommand("update stocks set quantity=quantity+'" + quantityval.Text + "'", con);
                    cmda.ExecuteNonQuery();
                    cmda1 = new SqlCommand("update stocks set freeqty=freeqty+'" + freeqtyvalu.Text + "'", con);
                    cmda1.ExecuteNonQuery();

                }
                else
                {
                    cmd = new SqlCommand("insert into stocks(productname,prcode,quantity,freeqty) values('" + comboBox2.Text + "','" + comboBox1.Text + "','" + quantityval.Text + "','" + freeqtyvalu.Text + "')", con);
                    cmd.ExecuteNonQuery();
                }
            }






            catch (Exception ex)
            {
                MessageBox.Show("CLOSING", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }





        public void disp_data()
        {
            //try
            //{

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select vendor,invoiceno,cash,prcode,perprice,sellprice,mrp,optprice,tax from  purchaseentry";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            /*  }
              catch (Exception)
              {
                  MessageBox.Show("Something ERROR", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

              }
              finally
              {
                  con.Close();
              }*/


        }

        private void VIEWALL_Click(object sender, EventArgs e)
        {




            try
            {
                SqlCommand cmd = new SqlCommand("select * from purchaseentry", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
            }

            catch (Exception)
            {
                MessageBox.Show("ERROR TO LOAD OR DATA NOT AVAILABE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult dialog = new DialogResult();
                
                dialog = MessageBox.Show("WANT TO DELETE FROM STOCKS But Stocks Must Not less than 0 Check first?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                

               if (dialog == DialogResult.Yes)
                {
                   
                        
                      SqlCommand cmda, cmda1;
                      cmda = new SqlCommand("update stocks set quantity=quantity-'" + quantityval.Text + "'", con);
                      cmda.ExecuteNonQuery();
                      cmda1 = new SqlCommand("update stocks set freeqty=freeqty-'" + freeqtyvalu.Text + "'", con);
                      cmda1.ExecuteNonQuery();
                      SqlCommand sc = new SqlCommand("delete from purchaseentry where  vendor='" + comboBox3.Text + "' AND productname='" + comboBox2.Text + "' ", con);
                      sc.ExecuteNonQuery();

                }
                else
                {
                    SqlCommand s1c = new SqlCommand("delete from purchaseentry where  vendor='" + comboBox3.Text + "' AND productname='" + comboBox2.Text + "' AND invoiceno='"+invoicenoval.Text+"'   ", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            invoicenoval.Clear();
            batchval.Clear();

            quantityval.Clear();
            freeqtyvalu.Clear();
            discountval.Clear();
            purpriceval.Clear();
            sellpriceval.Clear();
            mrpval.Clear();
            optpriceval.Clear();
            taxval.Clear();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Update();
                dataGridView1.Refresh();
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                comboBox3.Text = selectedRow.Cells[0].Value.ToString();
                invoicenoval.Text = selectedRow.Cells[1].Value.ToString();
                domainUpDown1.Text = selectedRow.Cells[2].Value.ToString();
                comboBox1.Text = selectedRow.Cells[3].Value.ToString();             
                purpriceval.Text = selectedRow.Cells[4].Value.ToString();
                sellpriceval.Text = selectedRow.Cells[5].Value.ToString();
                mrpval.Text = selectedRow.Cells[6].Value.ToString();
                optpriceval.Text = selectedRow.Cells[7].Value.ToString();
                taxval.Text = selectedRow.Cells[8].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells[9].Value.ToString();
                 dateTimePicker2.Text = selectedRow.Cells[10].Value.ToString();
                dateTimePicker3.Text = selectedRow.Cells[11].Value.ToString();
                comboBox2.Text = selectedRow.Cells[12].Value.ToString();
                 batchval.Text = selectedRow.Cells[13].Value.ToString();
                dateTimePicker4.Text = selectedRow.Cells[14].Value.ToString();
                quantityval.Text = selectedRow.Cells[15].Value.ToString();
                freeqtyvalu.Text = selectedRow.Cells[16].Value.ToString();
                discountval.Text = selectedRow.Cells[17].Value.ToString();
                textBox6.Text = selectedRow.Cells[18].Value.ToString();
                textBox25.Text = selectedRow.Cells[19].Value.ToString();
                textBox24.Text = selectedRow.Cells[20].Value.ToString();
                textBox23.Text = selectedRow.Cells[21].Value.ToString();
                textBox22.Text = selectedRow.Cells[22].Value.ToString();
                textBox12.Text = selectedRow.Cells[23].Value.ToString();
                textBox8.Text = selectedRow.Cells[24].Value.ToString();
                textBox9.Text = selectedRow.Cells[25].Value.ToString();
                textBox10.Text = selectedRow.Cells[26].Value.ToString();
                textBox11.Text = selectedRow.Cells[27].Value.ToString();
                subtotalval.Text = selectedRow.Cells[28].Value.ToString();
                discval.Text = selectedRow.Cells[29].Value.ToString();
                afterdiscval.Text = selectedRow.Cells[30].Value.ToString();
                creditval.Text = selectedRow.Cells[31].Value.ToString();
                debitvaltaxvoice.Text = selectedRow.Cells[32].Value.ToString();
                gsttotalval.Text = selectedRow.Cells[33].Value.ToString();
                cgstval.Text = selectedRow.Cells[34].Value.ToString();
                sgstval.Text = selectedRow.Cells[35].Value.ToString();
                igstval.Text = selectedRow.Cells[36].Value.ToString();
                textBox7.Text = selectedRow.Cells[37].Value.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Select one at a time only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select *  from product where productname='" + comboBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    textBox1.Text = (dr["manufacturer"].ToString());
                    textBox2.Text = (dr["hsncode"].ToString());
                    textBox3.Text = (dr["packaging"].ToString());
                    comboBox1.Text = (dr["productcode"].ToString());
                }
                else
                {
                    textBox3.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }



            catch (Exception)
            {
                MessageBox.Show("No quantity Of Product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                String query = "select productname  from product where productcode='" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    comboBox2.Text = (dr["productname"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO Quantity of product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }


        }

        private void AddVendors_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            {
                switch (MessageBox.Show(this, "ARE YOU SURE TO CLOSE", mstrClsTitle + "CLOSING FORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }

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
                    string a = quantityval.Text.ToString();
                    string fr = freeqtyvalu.Text.ToString();
                    String query = "select *  from purchaseentry where productname='" + comboBox2.Text + "'  AND vendor='" + comboBox3.Text + "' AND receiveddate='" + dateTimePicker2.Text + "'  AND invoicedate='"+dateTimePicker1.Text+"'  AND sellprice='"+sellpriceval.Text+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string b,myfree;
                        b = (dr["quantity"].ToString());
                        myfree = (dr["freeqty"].ToString());
                        int l, m,forfree,nsfree;
                        l = Convert.ToInt16(a.ToString());
                        m = Convert.ToInt16(b.ToString());
                        forfree = Convert.ToInt16(fr.ToString());
                        nsfree = Convert.ToInt16(myfree.ToString());
                        if (l < m  )
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

                            int p = forfree-nsfree;
                            SqlCommand cmda;
                            cmda = new SqlCommand("update stocks set freeqty=freeqty+'" + p + "'", con);
                            cmda.ExecuteNonQuery();
                        }
                    }
                    SqlCommand sc1 = new SqlCommand();
                    sc1.CommandText = @"update purchaseentry set  cash='" + domainUpDown1.Text + "' , prcode='" + comboBox1.Text + "' , perprice='" + purpriceval.Text + "' , sellprice='" + sellpriceval.Text + "' , mrp='" + mrpval.Text + "' , optprice='" + optpriceval.Text + "' , tax='" + taxval.Text + "' ,  invoicedate='" + dateTimePicker1.Text + "' , lrdate='" + dateTimePicker3.Text + "', productname='" + comboBox2.Text + "' , batch='" + batchval.Text + "' , expdate='" + dateTimePicker4.Text + "' , quantity='" + quantityval.Text + "' , freeqty='" + freeqtyvalu.Text + "' , discount='" + discountval.Text + "' , tax0='" + textBox12.Text + "',tax5='" + textBox8.Text + "',tax12='" + textBox9.Text + "',tax18='" + textBox10.Text + "',tax28='" + textBox11.Text + "',val0='" + textBox6.Text + "' ,val5='" + textBox25.Text + "' ,val12='" + textBox24.Text + "' ,val18='" + textBox23.Text + "' ,val28='" + textBox22.Text + "', Subtotal='" + subtotalval.Text + "' ,discval='" + discvalu.Text + "' ,afterdisc='" + afterdiscval.Text + "' ,credit='" + creditval.Text + "' , debit='" + debitvaltaxvoice.Text + "',gsttotal='" + gsttotalval.Text + "',CGST='" + cgstval.Text + "' ,SGST='" + sgstval.Text + "' ,IGST='" + igstval.Text + "',totalvalue='" + textBox7.Text + "'  where receiveddate='" + dateTimePicker2.Text + "'  AND  vendor='" + comboBox3.Text + "'   ";
                    sc1.Connection = con;
                    sc1.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.Refresh();
                }
                else
                {
                    SqlCommand sc = new SqlCommand();
                    sc.CommandText = @"update purchaseentry set invoiceno='" + invoicenoval.Text + "' , cash='" + domainUpDown1.Text + "' , prcode='" + comboBox1.Text + "' , perprice='" + purpriceval.Text + "' , sellprice='" + sellpriceval.Text + "' , mrp='" + mrpval.Text + "' , optprice='" + optpriceval.Text + "' , tax='" + taxval.Text + "' ,  invoicedate='" + dateTimePicker1.Text + "' , receiveddate='" + dateTimePicker2.Text + "' ,lrdate='" + dateTimePicker3.Text + "', productname='" + comboBox2.Text + "' , batch='" + batchval.Text + "' , expdate='" + dateTimePicker4.Text + "' , quantity='" + quantityval.Text + "' , freeqty='" + freeqtyvalu.Text + "' , discount='" + discountval.Text + "' , tax0='" + textBox12.Text + "',tax5='" + textBox8.Text + "',tax12='" + textBox9.Text + "',tax18='" + textBox10.Text + "',tax28='" + textBox11.Text + "',val0='" + textBox6.Text + "' ,val5='" + textBox25.Text + "' ,val12='" + textBox24.Text + "' ,val18='" + textBox23.Text + "' ,val28='" + textBox22.Text + "', Subtotal='"+subtotalval.Text+"' ,discval='"+discvalu.Text+"' ,afterdisc='"+afterdiscval.Text+"' ,credit='"+creditval.Text+"' , debit='"+debitvaltaxvoice.Text+"',gsttotal='"+gsttotalval.Text+"',CGST='"+cgstval.Text+"' ,SGST='"+sgstval.Text+"' ,IGST='"+igstval.Text+"',totalvalue='"+textBox7.Text+"'  where vendor='" + comboBox3.Text + "'  ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}