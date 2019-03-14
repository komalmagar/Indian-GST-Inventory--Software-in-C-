namespace komal
{
    partial class MyVouchers
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
            this.button2 = new System.Windows.Forms.Button();
            this.paymentsTableAdapter = new komal.paymentTableAdapters.paymentsTableAdapter();
            this.vender = new System.Windows.Forms.ComboBox();
            this.payment = new komal.payment();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.collections = new komal.collections();
            this.collectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionsTableAdapter = new komal.collectionsTableAdapters.collectionsTableAdapter();
            this.Expences1 = new komal.Expences1();
            this.expencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expencesTableAdapter = new komal.Expences1TableAdapters.expencesTableAdapter();
            this.expencess = new komal.expencess();
            this.expencesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expencesTableAdapter1 = new komal.expencessTableAdapters.expencesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expences1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1015, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "CHECK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // vender
            // 
            this.vender.DataSource = this.expencesBindingSource1;
            this.vender.DisplayMember = "paymentname";
            this.vender.FormattingEnabled = true;
            this.vender.Location = new System.Drawing.Point(869, 53);
            this.vender.Name = "vender";
            this.vender.Size = new System.Drawing.Size(140, 21);
            this.vender.TabIndex = 18;
            // 
            // payment
            // 
            this.payment.DataSetName = "payment";
            this.payment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "View By Payee";
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.payment;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(647, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.expencesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1024, 479);
            this.reportViewer1.TabIndex = 15;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "FROM";
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(418, 52);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(200, 20);
            this.todate.TabIndex = 11;
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(136, 51);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(189, 20);
            this.fromdate.TabIndex = 10;
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
            // Expences1
            // 
            this.Expences1.DataSetName = "Expences1";
            this.Expences1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expencesBindingSource
            // 
            this.expencesBindingSource.DataMember = "expences";
            this.expencesBindingSource.DataSource = this.Expences1;
            // 
            // expencesTableAdapter
            // 
            this.expencesTableAdapter.ClearBeforeFill = true;
            // 
            // expencess
            // 
            this.expencess.DataSetName = "expencess";
            this.expencess.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expencesBindingSource1
            // 
            this.expencesBindingSource1.DataMember = "expences";
            this.expencesBindingSource1.DataSource = this.expencess;
            // 
            // expencesTableAdapter1
            // 
            this.expencesTableAdapter1.ClearBeforeFill = true;
            // 
            // MyVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.fromdate);
            this.Name = "MyVouchers";
            this.Text = "MyVouchers";
            this.Load += new System.EventHandler(this.MyVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Expences1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private paymentTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.ComboBox vender;
        private payment payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.BindingSource collectionsBindingSource;
        private collections collections;
        private collectionsTableAdapters.collectionsTableAdapter collectionsTableAdapter;
        private System.Windows.Forms.BindingSource expencesBindingSource;
        private Expences1 Expences1;
        private Expences1TableAdapters.expencesTableAdapter expencesTableAdapter;
        private expencess expencess;
        private System.Windows.Forms.BindingSource expencesBindingSource1;
        private expencessTableAdapters.expencesTableAdapter expencesTableAdapter1;
    }
}