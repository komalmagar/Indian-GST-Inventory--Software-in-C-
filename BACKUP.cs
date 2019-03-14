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
using Excel = Microsoft.Office.Interop.Excel; 

namespace komal
{
    public partial class BACKUP : Form
    {
        public BACKUP()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "USE master;";
            string str1 = "ALTER DATABASE master SET SINGLE_USER WITH ROLLBACK IMMEDIATE; ";
            string str3 = "RESTORE DATABASE master FROM DISK= '"+textBox1.Text+"' WITH REPLACE ";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlCommand cmd2 = new SqlCommand(str3, con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("DataBase Recoverd Successfully.If you want to recover data then must close application and start again");
            con.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.InitialDirectory = @"C:\";
            openfiledialog1.Title = "Brows Text File";
            openfiledialog1.CheckFileExists = true;
            openfiledialog1.CheckPathExists = true;

            openfiledialog1.DefaultExt = "csv";
            openfiledialog1.Filter = "Text files(*.csv)|*.csv";
            openfiledialog1.FilterIndex = 2;
            openfiledialog1.RestoreDirectory = true;
            openfiledialog1.ReadOnlyChecked = true;
            openfiledialog1.ShowReadOnly = true;

            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openfiledialog1.FileName;
            }
        }
        
  
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionString = "Data Source=DESKTOP-848LD0K;Initial Catalog=master;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM purchaseentry";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);
            int ci;
            for (ci = 0; ci < ds.Tables[0].Columns.Count; ci++)
            {
                xlWorkSheet.Cells[1, ci + 1] = ds.Tables[0].Columns[ci].ColumnName;
                }
        
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs("purchases.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find t");
        
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    
        private void BACKUP_Load(object sender, EventArgs e)
        {

        }
    }
}
