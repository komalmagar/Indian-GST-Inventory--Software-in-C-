namespace komal
{
    partial class PaymentLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentLedger));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.vendername = new System.Windows.Forms.ComboBox();
            this.vender = new komal.vender();
            this.venderdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet7 = new komal.masterDataSet7();
            this.venderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venderdetailsTableAdapter = new komal.venderTableAdapters.venderdetailsTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.paymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet1 = new komal.masterDataSet1();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.paymentsTableAdapter = new komal.masterDataSet1TableAdapters.paymentsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.venderdetailsTableAdapter1 = new komal.masterDataSet7TableAdapters.venderdetailsTableAdapter();
            this.salesreturn12 = new komal.salesreturn12();
            this.salesreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.salesreturnTableAdapter = new komal.salesreturn12TableAdapters.salesreturnTableAdapter();
            this.AdvancerworldDataSet = new komal.AdvancerworldDataSet();
            this.masterDataSet9 = new komal.masterDataSet9();
            this.venderdetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.venderdetailsTableAdapter2 = new komal.masterDataSet9TableAdapters.venderdetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturn12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancerworldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(577, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ViewAll";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vendername
            // 
            this.vendername.DataSource = this.venderdetailsBindingSource2;
            this.vendername.DisplayMember = "vendername";
            this.vendername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vendername.FormattingEnabled = true;
            this.vendername.Location = new System.Drawing.Point(12, 35);
            this.vendername.Name = "vendername";
            this.vendername.Size = new System.Drawing.Size(227, 21);
            this.vendername.TabIndex = 5;
            // 
            // vender
            // 
            this.vender.DataSetName = "vender";
            this.vender.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venderdetailsBindingSource1
            // 
            this.venderdetailsBindingSource1.DataMember = "venderdetails";
            this.venderdetailsBindingSource1.DataSource = this.masterDataSet7;
            // 
            // masterDataSet7
            // 
            this.masterDataSet7.DataSetName = "masterDataSet7";
            this.masterDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venderdetailsBindingSource
            // 
            this.venderdetailsBindingSource.DataMember = "venderdetails";
            this.venderdetailsBindingSource.DataSource = this.vender;
            // 
            // venderdetailsTableAdapter
            // 
            this.venderdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // paymentsBindingSource1
            // 
            this.paymentsBindingSource1.DataMember = "payments";
            this.paymentsBindingSource1.DataSource = this.masterDataSet1;
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet1";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "Staffnames";
            reportDataSource4.Value = this.paymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(912, 411);
            this.reportViewer1.TabIndex = 8;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // venderdetailsTableAdapter1
            // 
            this.venderdetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // salesreturn12
            // 
            this.salesreturn12.DataSetName = "salesreturn12";
            this.salesreturn12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesreturnBindingSource
            // 
            this.salesreturnBindingSource.DataMember = "salesreturn";
            this.salesreturnBindingSource.DataSource = this.salesreturn12;
            // 
            // salesreturnTableAdapter
            // 
           // this.salesreturnTableAdapter.ClearBeforeFill = true;
            // 
            // AdvancerworldDataSet
            // 
            this.AdvancerworldDataSet.DataSetName = "AdvancerworldDataSet";
            this.AdvancerworldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSet9
            // 
            this.masterDataSet9.DataSetName = "masterDataSet9";
            this.masterDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venderdetailsBindingSource2
            // 
            this.venderdetailsBindingSource2.DataMember = "venderdetails";
            this.venderdetailsBindingSource2.DataSource = this.masterDataSet9;
            // 
            // venderdetailsTableAdapter2
            // 
            this.venderdetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // PaymentLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 502);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.vendername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Name = "PaymentLedger";
            this.Text = "PaymentLedger";
            this.Load += new System.EventHandler(this.PaymentLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturn12)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancerworldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox vendername;
        private vender vender;
        private System.Windows.Forms.BindingSource venderdetailsBindingSource;
        private venderTableAdapters.venderdetailsTableAdapter venderdetailsTableAdapter;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
       // private payments1 payments1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        //private payments1TableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private masterDataSet1 masterDataSet1;
        private System.Windows.Forms.BindingSource paymentsBindingSource1;
        private masterDataSet1TableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private masterDataSet7 masterDataSet7;
        private System.Windows.Forms.BindingSource venderdetailsBindingSource1;
        private masterDataSet7TableAdapters.venderdetailsTableAdapter venderdetailsTableAdapter1;
        private System.Windows.Forms.BindingSource salesreturnBindingSource;
        private salesreturn12 salesreturn12;
       // private salesreturn12TableAdapters.salesreturnTableAdapter salesreturnTableAdapter;
        private AdvancerworldDataSet AdvancerworldDataSet;
        private masterDataSet9 masterDataSet9;
        private System.Windows.Forms.BindingSource venderdetailsBindingSource2;
        private masterDataSet9TableAdapters.venderdetailsTableAdapter venderdetailsTableAdapter2;
        //private komal.AdventureWorksDataSet AdventureWorksDataSet;
       // private Paymentledgerdata Paymentledgerdata;
    }
}