namespace komal
{
    partial class SalesLedger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.salesreturn12 = new komal.salesreturn12();
            this.vender = new komal.vender();
            this.venderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MasterPurchase = new komal.MasterPurchase();
            this.taxinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxinvoiceTableAdapter = new komal.MasterPurchaseTableAdapters.taxinvoiceTableAdapter();
            this.vendername = new System.Windows.Forms.ComboBox();
            this.collections = new komal.collections();
            this.collectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionsTableAdapter = new komal.collectionsTableAdapters.collectionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturn12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            // 
            // salesreturnBindingSource
            // 
            this.salesreturnBindingSource.DataMember = "salesreturn";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "PurchaseTaxInvoice";
            reportDataSource2.Value = this.taxinvoiceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(922, 459);
            this.reportViewer1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(862, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "ViewAll";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // salesreturn12
            // 
            this.salesreturn12.DataSetName = "salesreturn12";
            this.salesreturn12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vender
            // 
            this.vender.DataSetName = "vender";
            this.vender.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venderBindingSource
            // 
            this.venderBindingSource.DataSource = this.vender;
            this.venderBindingSource.Position = 0;
            // 
            // MasterPurchase
            // 
            this.MasterPurchase.DataSetName = "MasterPurchase";
            this.MasterPurchase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxinvoiceBindingSource
            // 
            this.taxinvoiceBindingSource.DataMember = "taxinvoice";
            this.taxinvoiceBindingSource.DataSource = this.MasterPurchase;
            // 
            // taxinvoiceTableAdapter
            // 
            this.taxinvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // vendername
            // 
            this.vendername.DataSource = this.collectionsBindingSource;
            this.vendername.DisplayMember = "vendername";
            this.vendername.FormattingEnabled = true;
            this.vendername.Location = new System.Drawing.Point(12, 34);
            this.vendername.Name = "vendername";
            this.vendername.Size = new System.Drawing.Size(169, 21);
            this.vendername.TabIndex = 9;
            // 
            // collections
            // 
            this.collections.DataSetName = "collections";
            this.collections.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collectionsBindingSource
            // 
            this.collectionsBindingSource.DataMember = "collections";
            this.collectionsBindingSource.DataSource = this.collections;
            // 
            // collectionsTableAdapter
            // 
            this.collectionsTableAdapter.ClearBeforeFill = true;
            // 
            // SalesLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 540);
            this.Controls.Add(this.vendername);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Name = "SalesLedger";
            this.Text = "SalesLedger";
            this.Load += new System.EventHandler(this.SalesLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturn12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource salesreturnBindingSource;
      //  private DataSet1 DataSet1;
       // private DataSet1TableAdapters.salesreturnTableAdapter salesreturnTableAdapter;
        private salesreturn12 salesreturn12;
        private vender vender;
        private System.Windows.Forms.BindingSource venderBindingSource;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private System.Windows.Forms.BindingSource taxinvoiceBindingSource;
        private MasterPurchase MasterPurchase;
        private MasterPurchaseTableAdapters.taxinvoiceTableAdapter taxinvoiceTableAdapter;
        private System.Windows.Forms.ComboBox vendername;
        private collections collections;
        private System.Windows.Forms.BindingSource collectionsBindingSource;
        private collectionsTableAdapters.collectionsTableAdapter collectionsTableAdapter;
        //private DataSet2 DataSet2;
        //private DataSet2TableAdapters.paymentsTableAdapter paymentsTableAdapter;
       // private masterDataSet12 masterDataSet12;
        // private masterDataSet12TableAdapters.salesreturnTableAdapter salesreturnTableAdapter;
    }
}