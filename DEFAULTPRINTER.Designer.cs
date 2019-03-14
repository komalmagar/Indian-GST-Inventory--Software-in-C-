namespace komal
{
    partial class DEFAULTPRINTER
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new komal.DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toname = new System.Windows.Forms.ComboBox();
            this.taxinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet16 = new komal.masterDataSet16();
            this.button1 = new System.Windows.Forms.Button();
            this.taxinvoiceTableAdapter = new komal.masterDataSet16TableAdapters.taxinvoiceTableAdapter();
            this.DataTable1TableAdapter = new komal.DataSet3TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet3;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1059, 619);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_2);
            // 
            // toname
            // 
            this.toname.DataSource = this.taxinvoiceBindingSource;
            this.toname.DisplayMember = "toname";
            this.toname.FormattingEnabled = true;
            this.toname.Location = new System.Drawing.Point(12, 12);
            this.toname.Name = "toname";
            this.toname.Size = new System.Drawing.Size(222, 21);
            this.toname.TabIndex = 1;
            // 
            // taxinvoiceBindingSource
            // 
            this.taxinvoiceBindingSource.DataMember = "taxinvoice";
            this.taxinvoiceBindingSource.DataSource = this.masterDataSet16;
            // 
            // masterDataSet16
            // 
            this.masterDataSet16.DataSetName = "masterDataSet16";
            this.masterDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taxinvoiceTableAdapter
            // 
            this.taxinvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DEFAULTPRINTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toname);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DEFAULTPRINTER";
            this.Text = "TAXINVOICEREPORT";
            this.Load += new System.EventHandler(this.DEFAULTPRINTER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox toname;
        private System.Windows.Forms.Button button1;
        private masterDataSet16 masterDataSet16;
        private System.Windows.Forms.BindingSource taxinvoiceBindingSource;
        private masterDataSet16TableAdapters.taxinvoiceTableAdapter taxinvoiceTableAdapter;
    }
}