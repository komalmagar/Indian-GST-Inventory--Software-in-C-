namespace komal
{
    partial class Standard
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
            this.toname = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.masterDataSet16 = new komal.masterDataSet16();
            this.masterDataSet16BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxInvoice1 = new komal.TaxInvoice1();
            this.taxInvoice1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet17 = new komal.masterDataSet17();
            this.taxinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxinvoiceTableAdapter = new komal.masterDataSet17TableAdapters.taxinvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet16BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxInvoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxInvoice1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toname
            // 
            this.toname.DataSource = this.taxinvoiceBindingSource;
            this.toname.DisplayMember = "toname";
            this.toname.FormattingEnabled = true;
            this.toname.Location = new System.Drawing.Point(12, 12);
            this.toname.Name = "toname";
            this.toname.Size = new System.Drawing.Size(157, 21);
            this.toname.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1054, 605);
            this.reportViewer1.TabIndex = 2;
            // 
            // masterDataSet16
            // 
            this.masterDataSet16.DataSetName = "masterDataSet16";
            this.masterDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSet16BindingSource
            // 
            this.masterDataSet16BindingSource.DataSource = this.masterDataSet16;
            this.masterDataSet16BindingSource.Position = 0;
            // 
            // taxInvoice1
            // 
            this.taxInvoice1.DataSetName = "TaxInvoice1";
            this.taxInvoice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxInvoice1BindingSource
            // 
            this.taxInvoice1BindingSource.DataSource = this.taxInvoice1;
            this.taxInvoice1BindingSource.Position = 0;
            // 
            // masterDataSet17
            // 
            this.masterDataSet17.DataSetName = "masterDataSet17";
            this.masterDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxinvoiceBindingSource
            // 
            this.taxinvoiceBindingSource.DataMember = "taxinvoice";
            this.taxinvoiceBindingSource.DataSource = this.masterDataSet17;
            // 
            // taxinvoiceTableAdapter
            // 
            this.taxinvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // Standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 672);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toname);
            this.Name = "Standard";
            this.Text = "Standard";
            this.Load += new System.EventHandler(this.Standard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet16BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxInvoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxInvoice1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxinvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox toname;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource taxInvoice1BindingSource;
        private TaxInvoice1 taxInvoice1;
        private masterDataSet16 masterDataSet16;
        private System.Windows.Forms.BindingSource masterDataSet16BindingSource;
        private masterDataSet17 masterDataSet17;
        private System.Windows.Forms.BindingSource taxinvoiceBindingSource;
        private masterDataSet17TableAdapters.taxinvoiceTableAdapter taxinvoiceTableAdapter;
    }
}