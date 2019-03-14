namespace komal
{
    partial class PuchaseTaxInvoices
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
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PurchasEntry = new komal.PurchasEntry();
            this.purchaseentryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseentryTableAdapter = new komal.PurchasEntryTableAdapters.purchaseentryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(84, 46);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(154, 20);
            this.fromdate.TabIndex = 0;
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(305, 46);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(154, 20);
            this.todate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "FROM";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(268, 46);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(31, 18);
            this.To.TabIndex = 3;
            this.To.Text = "TO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(597, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "ViewAll";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "PurchaseTaxInvoice";
            reportDataSource2.Value = this.purchaseentryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1075, 407);
            this.reportViewer1.TabIndex = 6;
            // 
            // PurchasEntry
            // 
            this.PurchasEntry.DataSetName = "PurchasEntry";
            this.PurchasEntry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseentryBindingSource
            // 
            this.purchaseentryBindingSource.DataMember = "purchaseentry";
            this.purchaseentryBindingSource.DataSource = this.PurchasEntry;
            // 
            // purchaseentryTableAdapter
            // 
            this.purchaseentryTableAdapter.ClearBeforeFill = true;
            // 
            // PuchaseTaxInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 535);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.fromdate);
            this.Name = "PuchaseTaxInvoices";
            this.Text = "PuchaseTaxInvoices";
            this.Load += new System.EventHandler(this.PuchaseTaxInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource purchaseentryBindingSource;
        private PurchasEntry PurchasEntry;
        private PurchasEntryTableAdapters.purchaseentryTableAdapter purchaseentryTableAdapter;
    }
}