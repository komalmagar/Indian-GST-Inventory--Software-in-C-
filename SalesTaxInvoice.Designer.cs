namespace komal
{
    partial class SalesTaxInvoice
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.TaxInvoice1 = new komal.TaxInvoice1();
            this.taxinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxinvoiceTableAdapter = new komal.TaxInvoice1TableAdapters.taxinvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TaxInvoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TaxInvoice";
            reportDataSource1.Value = this.taxinvoiceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(988, 436);
            this.reportViewer1.TabIndex = 18;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(531, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "View ALL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(409, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(254, 28);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(136, 20);
            this.todate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "FROM";
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(65, 28);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(136, 20);
            this.fromdate.TabIndex = 10;
            // 
            // TaxInvoice1
            // 
            this.TaxInvoice1.DataSetName = "TaxInvoice1";
            this.TaxInvoice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxinvoiceBindingSource
            // 
            this.taxinvoiceBindingSource.DataMember = "taxinvoice";
            this.taxinvoiceBindingSource.DataSource = this.TaxInvoice1;
            // 
            // taxinvoiceTableAdapter
            // 
            this.taxinvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // SalesTaxInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 536);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromdate);
            this.Name = "SalesTaxInvoice";
            this.Text = "SalesTaxInvoice";
            this.Load += new System.EventHandler(this.SalesTaxInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaxInvoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.BindingSource taxinvoiceBindingSource;
        private TaxInvoice1 TaxInvoice1;
        private TaxInvoice1TableAdapters.taxinvoiceTableAdapter taxinvoiceTableAdapter;
    }
}