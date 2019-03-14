namespace komal
{
    partial class StockReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.purchaseentryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PurchaseEntry = new komal.PurchaseEntry();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Product = new komal.Product();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.purchaseentryTableAdapter = new komal.PurchaseEntryTableAdapters.purchaseentryTableAdapter();
            this.productTableAdapter = new komal.ProductTableAdapters.productTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.vendor = new System.Windows.Forms.ComboBox();
            this.masterDataSet14 = new komal.masterDataSet14();
            this.purchaseentryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseentryTableAdapter1 = new komal.masterDataSet14TableAdapters.purchaseentryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseentryBindingSource
            // 
            this.purchaseentryBindingSource.DataMember = "purchaseentry";
            this.purchaseentryBindingSource.DataSource = this.PurchaseEntry;
            // 
            // PurchaseEntry
            // 
            this.PurchaseEntry.DataSetName = "PurchaseEntry";
            this.PurchaseEntry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.Product;
            // 
            // Product
            // 
            this.Product.DataSetName = "Product";
            this.Product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource7.Name = "Combine";
            reportDataSource7.Value = this.purchaseentryBindingSource;
            reportDataSource8.Name = "Product";
            reportDataSource8.Value = this.productBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(970, 448);
            this.reportViewer1.TabIndex = 27;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(249, 26);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(136, 20);
            this.todate.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "FROM";
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(60, 26);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(136, 20);
            this.fromdate.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // purchaseentryTableAdapter
            // 
            this.purchaseentryTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "VIEWBYVENDER";
            // 
            // vendor
            // 
            this.vendor.DataSource = this.purchaseentryBindingSource1;
            this.vendor.DisplayMember = "vendor";
            this.vendor.FormattingEnabled = true;
            this.vendor.Location = new System.Drawing.Point(669, 28);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(178, 21);
            this.vendor.TabIndex = 33;
            // 
            // masterDataSet14
            // 
            this.masterDataSet14.DataSetName = "masterDataSet14";
            this.masterDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseentryBindingSource1
            // 
            this.purchaseentryBindingSource1.DataMember = "purchaseentry";
            this.purchaseentryBindingSource1.DataSource = this.masterDataSet14;
            // 
            // purchaseentryTableAdapter1
            // 
            this.purchaseentryTableAdapter1.ClearBeforeFill = true;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 537);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromdate);
            this.Name = "StockReport";
            this.Text = "StockReport";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource purchaseentryBindingSource;
        private PurchaseEntry PurchaseEntry;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Product Product;
        private PurchaseEntryTableAdapters.purchaseentryTableAdapter purchaseentryTableAdapter;
        private ProductTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vendor;
        private masterDataSet14 masterDataSet14;
        private System.Windows.Forms.BindingSource purchaseentryBindingSource1;
        private masterDataSet14TableAdapters.purchaseentryTableAdapter purchaseentryTableAdapter1;
    }
}