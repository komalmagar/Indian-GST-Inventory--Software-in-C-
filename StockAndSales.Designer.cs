namespace komal
{
    partial class StockAndSales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.salesreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Salereturn = new komal.Salereturn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.salesreturnTableAdapter = new komal.SalereturnTableAdapters.salesreturnTableAdapter();
            this.vendor = new System.Windows.Forms.ComboBox();
            this.masterDataSet12 = new komal.masterDataSet12();
            this.salesreturnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesreturnTableAdapter1 = new komal.masterDataSet12TableAdapters.salesreturnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salereturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesreturnBindingSource
            // 
            this.salesreturnBindingSource.DataMember = "salesreturn";
            this.salesreturnBindingSource.DataSource = this.Salereturn;
            // 
            // Salereturn
            // 
            this.Salereturn.DataSetName = "Salereturn";
            this.Salereturn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(851, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "SalesReturn";
            reportDataSource4.Value = this.salesreturnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1013, 446);
            this.reportViewer1.TabIndex = 36;
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(247, 28);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(136, 20);
            this.todate.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "FROM";
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(67, 29);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(136, 20);
            this.fromdate.TabIndex = 32;
            // 
            // salesreturnTableAdapter
            // 
            this.salesreturnTableAdapter.ClearBeforeFill = true;
            // 
            // vendor
            // 
            this.vendor.DataSource = this.salesreturnBindingSource1;
            this.vendor.DisplayMember = "fromcustomer";
            this.vendor.FormattingEnabled = true;
            this.vendor.Location = new System.Drawing.Point(681, 30);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(164, 21);
            this.vendor.TabIndex = 41;
            // 
            // masterDataSet12
            // 
            this.masterDataSet12.DataSetName = "masterDataSet12";
            this.masterDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesreturnBindingSource1
            // 
            this.salesreturnBindingSource1.DataMember = "salesreturn";
            this.salesreturnBindingSource1.DataSource = this.masterDataSet12;
            // 
            // salesreturnTableAdapter1
            // 
            this.salesreturnTableAdapter1.ClearBeforeFill = true;
            // 
            // StockAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 542);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromdate);
            this.Name = "StockAndSales";
            this.Text = "StockAndSales";
            this.Load += new System.EventHandler(this.StockAndSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salereturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesreturnBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.BindingSource salesreturnBindingSource;
        private Salereturn Salereturn;
        private SalereturnTableAdapters.salesreturnTableAdapter salesreturnTableAdapter;
        private System.Windows.Forms.ComboBox vendor;
        private masterDataSet12 masterDataSet12;
        private System.Windows.Forms.BindingSource salesreturnBindingSource1;
        private masterDataSet12TableAdapters.salesreturnTableAdapter salesreturnTableAdapter1;
    }
}