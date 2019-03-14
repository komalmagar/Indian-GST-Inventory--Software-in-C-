namespace komal
{
    partial class MYCollectionch
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
            this.button2 = new System.Windows.Forms.Button();
            this.paymentsTableAdapter = new komal.paymentTableAdapters.paymentsTableAdapter();
            this.vender = new System.Windows.Forms.ComboBox();
            this.payment = new komal.payment();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.collections = new komal.collections();
            this.collectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionsTableAdapter = new komal.collectionsTableAdapters.collectionsTableAdapter();
            this.paymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(930, 44);
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
            this.vender.DataSource = this.paymentsBindingSource1;
            this.vender.DisplayMember = "vendername";
            this.vender.FormattingEnabled = true;
            this.vender.Location = new System.Drawing.Point(784, 46);
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
            this.label3.Location = new System.Drawing.Point(813, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "PAYEE";
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.payment;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(631, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "mycollection";
            reportDataSource4.Value = this.collectionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "komal.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1078, 479);
            this.reportViewer1.TabIndex = 15;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(622, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "VIEWALL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "FROM";
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(402, 48);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(200, 20);
            this.todate.TabIndex = 11;
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(120, 47);
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
            // paymentsBindingSource1
            // 
            this.paymentsBindingSource1.DataMember = "payments";
            this.paymentsBindingSource1.DataSource = this.payment;
            // 
            // MYCollectionch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 695);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.fromdate);
            this.Name = "MYCollectionch";
            this.Text = "MYCollectionch";
            this.Load += new System.EventHandler(this.MYCollectionch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.BindingSource collectionsBindingSource;
        private collections collections;
        private collectionsTableAdapters.collectionsTableAdapter collectionsTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource1;
    }
}