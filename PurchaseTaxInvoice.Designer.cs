namespace komal
{
    partial class PurchaseTaxInvoice
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
            this.taxinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MasterPurchase = new komal.MasterPurchase();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.taxinvoiceTableAdapter = new komal.MasterPurchaseTableAdapters.taxinvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // taxinvoiceBindingSource
            // 
            this.taxinvoiceBindingSource.DataMember = "taxinvoice";
            this.taxinvoiceBindingSource.DataSource = this.MasterPurchase;
            // 
            // MasterPurchase
            // 
            this.MasterPurchase.DataSetName = "MasterPurchase";
            this.MasterPurchase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(78, 36);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(136, 20);
            this.fromdate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TO";
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(267, 36);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(136, 20);
            this.todate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(422, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(526, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "CGST/SGST Invoice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(836, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "View ALL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PurchaseInvoice";
            reportDataSource1.Value = this.taxinvoiceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(950, 439);
            this.reportViewer1.TabIndex = 9;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // taxinvoiceTableAdapter
            // 
            this.taxinvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseTaxInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 542);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromdate);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "PurchaseTaxInvoice";
            this.Text = "PurchaseTaxInvoice";
            this.Load += new System.EventHandler(this.PurchaseTaxInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource taxinvoiceBindingSource;
        private MasterPurchase MasterPurchase;
        private MasterPurchaseTableAdapters.taxinvoiceTableAdapter taxinvoiceTableAdapter;
    }
}