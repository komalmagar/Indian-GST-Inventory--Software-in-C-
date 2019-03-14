namespace komal
{
    partial class MyPrint
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
            this.dataSet3 = new komal.DataSet3();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new komal.DataSet3TableAdapters.DataTable1TableAdapter();
            this.toname = new System.Windows.Forms.ComboBox();
            this.masterDataSet18 = new komal.masterDataSet18();
            this.taxinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxinvoiceTableAdapter = new komal.masterDataSet18TableAdapters.taxinvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report13.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1034, 526);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // toname
            // 
            this.toname.DataSource = this.taxinvoiceBindingSource;
            this.toname.DisplayMember = "toname";
            this.toname.FormattingEnabled = true;
            this.toname.Location = new System.Drawing.Point(43, 28);
            this.toname.Name = "toname";
            this.toname.Size = new System.Drawing.Size(193, 21);
            this.toname.TabIndex = 3;
            this.toname.SelectedIndexChanged += new System.EventHandler(this.toname_SelectedIndexChanged);
            // 
            // masterDataSet18
            // 
            this.masterDataSet18.DataSetName = "masterDataSet18";
            this.masterDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxinvoiceBindingSource
            // 
            this.taxinvoiceBindingSource.DataMember = "taxinvoice";
            this.taxinvoiceBindingSource.DataSource = this.masterDataSet18;
            // 
            // taxinvoiceTableAdapter
            // 
            this.taxinvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // MyPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 621);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toname);
            this.Name = "MyPrint";
            this.Text = "MyPrint";
            this.Load += new System.EventHandler(this.MyPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private DataSet3TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.ComboBox toname;
        private masterDataSet18 masterDataSet18;
        private System.Windows.Forms.BindingSource taxinvoiceBindingSource;
        private masterDataSet18TableAdapters.taxinvoiceTableAdapter taxinvoiceTableAdapter;
    }
}