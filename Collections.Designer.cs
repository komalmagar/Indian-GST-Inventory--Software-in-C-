namespace komal
{
    partial class Collections
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.Button();
            this.vendernamevalu = new System.Windows.Forms.ComboBox();
            this.venderdetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vender = new komal.vender();
            this.venderdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.venderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PAY = new System.Windows.Forms.Button();
            this.discountvalue = new System.Windows.Forms.TextBox();
            this.amountvalue = new System.Windows.Forms.TextBox();
            this.invoicenumbervalue = new System.Windows.Forms.TextBox();
            this.vouchernumbervalue = new System.Windows.Forms.TextBox();
            this.datevalue = new System.Windows.Forms.DateTimePicker();
            this.chequedatevalue = new System.Windows.Forms.DateTimePicker();
            this.chequenovalue = new System.Windows.Forms.TextBox();
            this.ipscvalue = new System.Windows.Forms.TextBox();
            this.bankaccountvalue = new System.Windows.Forms.TextBox();
            this.banknamevalue = new System.Windows.Forms.TextBox();
            this.paymentdescrptionvalue = new System.Windows.Forms.TextBox();
            this.purchaseentryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PAYOPTIONVALUE = new System.Windows.Forms.ComboBox();
            this.totalvaluetext = new System.Windows.Forms.TextBox();
            this.VoucherNumber = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.InvoiceNo = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.gatdata = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.ChequeDate = new System.Windows.Forms.Label();
            this.IPSC = new System.Windows.Forms.Label();
            this.ChequeNo = new System.Windows.Forms.Label();
            this.PaymentMode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BankName = new System.Windows.Forms.Label();
            this.PaymentDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VendorName = new System.Windows.Forms.Label();
            this.venderdetailsTableAdapter = new komal.venderTableAdapters.venderdetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1242, 252);
            this.dataGridView1.TabIndex = 102;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.View.BackColor = System.Drawing.Color.Aqua;
            this.View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Location = new System.Drawing.Point(640, 598);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(85, 42);
            this.View.TabIndex = 101;
            this.View.Text = "View";
            this.View.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // vendernamevalu
            // 
            this.vendernamevalu.AllowDrop = true;
            this.vendernamevalu.AutoCompleteCustomSource.AddRange(new string[] {
            "PETROL"});
            this.vendernamevalu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vendernamevalu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vendernamevalu.DataSource = this.venderdetailsBindingSource2;
            this.vendernamevalu.DisplayMember = "vendername";
            this.vendernamevalu.FormattingEnabled = true;
            this.vendernamevalu.Location = new System.Drawing.Point(28, 57);
            this.vendernamevalu.Name = "vendernamevalu";
            this.vendernamevalu.Size = new System.Drawing.Size(173, 21);
            this.vendernamevalu.TabIndex = 100;
            // 
            // venderdetailsBindingSource2
            // 
            this.venderdetailsBindingSource2.DataMember = "venderdetails";
            this.venderdetailsBindingSource2.DataSource = this.vender;
            // 
            // vender
            // 
            this.vender.DataSetName = "vender";
            this.vender.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venderdetailsBindingSource1
            // 
            this.venderdetailsBindingSource1.DataMember = "venderdetails";
            // 
            // venderdetailsBindingSource
            // 
            this.venderdetailsBindingSource.DataMember = "venderdetails";
            // 
            // PAY
            // 
            this.PAY.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.PAY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PAY.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAY.Location = new System.Drawing.Point(1068, 264);
            this.PAY.Name = "PAY";
            this.PAY.Size = new System.Drawing.Size(90, 30);
            this.PAY.TabIndex = 99;
            this.PAY.Text = "PAY";
            this.PAY.UseVisualStyleBackColor = false;
            this.PAY.Click += new System.EventHandler(this.PAY_Click);
            // 
            // discountvalue
            // 
            this.discountvalue.Location = new System.Drawing.Point(940, 173);
            this.discountvalue.Name = "discountvalue";
            this.discountvalue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discountvalue.Size = new System.Drawing.Size(174, 20);
            this.discountvalue.TabIndex = 98;
            // 
            // amountvalue
            // 
            this.amountvalue.Location = new System.Drawing.Point(940, 224);
            this.amountvalue.Name = "amountvalue";
            this.amountvalue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountvalue.Size = new System.Drawing.Size(174, 20);
            this.amountvalue.TabIndex = 97;
            // 
            // invoicenumbervalue
            // 
            this.invoicenumbervalue.Location = new System.Drawing.Point(940, 125);
            this.invoicenumbervalue.Multiline = true;
            this.invoicenumbervalue.Name = "invoicenumbervalue";
            this.invoicenumbervalue.Size = new System.Drawing.Size(174, 28);
            this.invoicenumbervalue.TabIndex = 96;
            // 
            // vouchernumbervalue
            // 
            this.vouchernumbervalue.Location = new System.Drawing.Point(940, 24);
            this.vouchernumbervalue.Multiline = true;
            this.vouchernumbervalue.Name = "vouchernumbervalue";
            this.vouchernumbervalue.Size = new System.Drawing.Size(174, 28);
            this.vouchernumbervalue.TabIndex = 95;
            // 
            // datevalue
            // 
            this.datevalue.Location = new System.Drawing.Point(940, 74);
            this.datevalue.Name = "datevalue";
            this.datevalue.Size = new System.Drawing.Size(201, 20);
            this.datevalue.TabIndex = 94;
            // 
            // chequedatevalue
            // 
            this.chequedatevalue.Location = new System.Drawing.Point(464, 285);
            this.chequedatevalue.Name = "chequedatevalue";
            this.chequedatevalue.Size = new System.Drawing.Size(201, 20);
            this.chequedatevalue.TabIndex = 93;
            // 
            // chequenovalue
            // 
            this.chequenovalue.Location = new System.Drawing.Point(464, 243);
            this.chequenovalue.Multiline = true;
            this.chequenovalue.Name = "chequenovalue";
            this.chequenovalue.Size = new System.Drawing.Size(174, 28);
            this.chequenovalue.TabIndex = 92;
            // 
            // ipscvalue
            // 
            this.ipscvalue.Location = new System.Drawing.Point(464, 200);
            this.ipscvalue.Multiline = true;
            this.ipscvalue.Name = "ipscvalue";
            this.ipscvalue.Size = new System.Drawing.Size(174, 28);
            this.ipscvalue.TabIndex = 91;
            // 
            // bankaccountvalue
            // 
            this.bankaccountvalue.Location = new System.Drawing.Point(464, 152);
            this.bankaccountvalue.Multiline = true;
            this.bankaccountvalue.Name = "bankaccountvalue";
            this.bankaccountvalue.Size = new System.Drawing.Size(174, 28);
            this.bankaccountvalue.TabIndex = 90;
            // 
            // banknamevalue
            // 
            this.banknamevalue.Location = new System.Drawing.Point(464, 109);
            this.banknamevalue.Multiline = true;
            this.banknamevalue.Name = "banknamevalue";
            this.banknamevalue.Size = new System.Drawing.Size(174, 28);
            this.banknamevalue.TabIndex = 89;
            // 
            // paymentdescrptionvalue
            // 
            this.paymentdescrptionvalue.Location = new System.Drawing.Point(27, 266);
            this.paymentdescrptionvalue.Multiline = true;
            this.paymentdescrptionvalue.Name = "paymentdescrptionvalue";
            this.paymentdescrptionvalue.Size = new System.Drawing.Size(174, 28);
            this.paymentdescrptionvalue.TabIndex = 88;
            // 
            // purchaseentryBindingSource
            // 
            this.purchaseentryBindingSource.DataMember = "purchaseentry";
            // 
            // PAYOPTIONVALUE
            // 
            this.PAYOPTIONVALUE.AllowDrop = true;
            this.PAYOPTIONVALUE.FormattingEnabled = true;
            this.PAYOPTIONVALUE.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "DEBIT",
            "PAYTM"});
            this.PAYOPTIONVALUE.Location = new System.Drawing.Point(28, 197);
            this.PAYOPTIONVALUE.Name = "PAYOPTIONVALUE";
            this.PAYOPTIONVALUE.Size = new System.Drawing.Size(173, 21);
            this.PAYOPTIONVALUE.TabIndex = 87;
            this.PAYOPTIONVALUE.Text = "Select";
            // 
            // totalvaluetext
            // 
            this.totalvaluetext.Location = new System.Drawing.Point(27, 125);
            this.totalvaluetext.Name = "totalvaluetext";
            this.totalvaluetext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalvaluetext.Size = new System.Drawing.Size(174, 20);
            this.totalvaluetext.TabIndex = 86;
            // 
            // VoucherNumber
            // 
            this.VoucherNumber.AutoSize = true;
            this.VoucherNumber.Location = new System.Drawing.Point(755, 24);
            this.VoucherNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VoucherNumber.Name = "VoucherNumber";
            this.VoucherNumber.Size = new System.Drawing.Size(87, 13);
            this.VoucherNumber.TabIndex = 81;
            this.VoucherNumber.Text = "Voucher Number";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(755, 74);
            this.Date.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 80;
            this.Date.Text = "Date";
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AutoSize = true;
            this.InvoiceNo.Location = new System.Drawing.Point(755, 125);
            this.InvoiceNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(62, 13);
            this.InvoiceNo.TabIndex = 79;
            this.InvoiceNo.Text = "Invoice No.";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(755, 173);
            this.Discount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(49, 13);
            this.Discount.TabIndex = 78;
            this.Discount.Text = "Discount";
            // 
            // gatdata
            // 
            this.gatdata.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.gatdata.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gatdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gatdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gatdata.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatdata.Location = new System.Drawing.Point(217, 55);
            this.gatdata.Name = "gatdata";
            this.gatdata.Size = new System.Drawing.Size(90, 30);
            this.gatdata.TabIndex = 85;
            this.gatdata.Text = "Get Data";
            this.gatdata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gatdata.UseVisualStyleBackColor = false;
            this.gatdata.Click += new System.EventHandler(this.gatdata_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(480, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 42);
            this.button2.TabIndex = 84;
            this.button2.Text = "Clear";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete.BackColor = System.Drawing.Color.Aqua;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Location = new System.Drawing.Point(331, 598);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 42);
            this.Delete.TabIndex = 83;
            this.Delete.Text = "Delete";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update.BackColor = System.Drawing.Color.Aqua;
            this.Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Location = new System.Drawing.Point(192, 598);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(85, 42);
            this.Update.TabIndex = 82;
            this.Update.Text = "Update";
            this.Update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(755, 224);
            this.Amount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 77;
            this.Amount.Text = "Amount";
            // 
            // ChequeDate
            // 
            this.ChequeDate.AutoSize = true;
            this.ChequeDate.Location = new System.Drawing.Point(309, 286);
            this.ChequeDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ChequeDate.Name = "ChequeDate";
            this.ChequeDate.Size = new System.Drawing.Size(70, 13);
            this.ChequeDate.TabIndex = 76;
            this.ChequeDate.Text = "Cheque Date";
            // 
            // IPSC
            // 
            this.IPSC.AutoSize = true;
            this.IPSC.Location = new System.Drawing.Point(309, 200);
            this.IPSC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IPSC.Name = "IPSC";
            this.IPSC.Size = new System.Drawing.Size(31, 13);
            this.IPSC.TabIndex = 75;
            this.IPSC.Text = "IPSC";
            // 
            // ChequeNo
            // 
            this.ChequeNo.AutoSize = true;
            this.ChequeNo.Location = new System.Drawing.Point(312, 243);
            this.ChequeNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ChequeNo.Name = "ChequeNo";
            this.ChequeNo.Size = new System.Drawing.Size(64, 13);
            this.ChequeNo.TabIndex = 74;
            this.ChequeNo.Text = "Cheque No.";
            // 
            // PaymentMode
            // 
            this.PaymentMode.AutoSize = true;
            this.PaymentMode.Location = new System.Drawing.Point(23, 173);
            this.PaymentMode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PaymentMode.Name = "PaymentMode";
            this.PaymentMode.Size = new System.Drawing.Size(81, 13);
            this.PaymentMode.TabIndex = 73;
            this.PaymentMode.Text = "Payment  Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Bank  ACC.";
            // 
            // BankName
            // 
            this.BankName.AutoSize = true;
            this.BankName.Location = new System.Drawing.Point(309, 112);
            this.BankName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BankName.Name = "BankName";
            this.BankName.Size = new System.Drawing.Size(66, 13);
            this.BankName.TabIndex = 71;
            this.BankName.Text = "Bank  Name";
            // 
            // PaymentDescription
            // 
            this.PaymentDescription.AutoSize = true;
            this.PaymentDescription.Location = new System.Drawing.Point(23, 243);
            this.PaymentDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PaymentDescription.Name = "PaymentDescription";
            this.PaymentDescription.Size = new System.Drawing.Size(107, 13);
            this.PaymentDescription.TabIndex = 70;
            this.PaymentDescription.Text = "Payment  Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Total  Value";
            // 
            // VendorName
            // 
            this.VendorName.AutoSize = true;
            this.VendorName.Location = new System.Drawing.Point(23, 24);
            this.VendorName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(72, 13);
            this.VendorName.TabIndex = 68;
            this.VendorName.Text = "Vendor Name";
            // 
            // venderdetailsTableAdapter
            // 
            this.venderdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Collections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.vendernamevalu);
            this.Controls.Add(this.PAY);
            this.Controls.Add(this.discountvalue);
            this.Controls.Add(this.amountvalue);
            this.Controls.Add(this.invoicenumbervalue);
            this.Controls.Add(this.vouchernumbervalue);
            this.Controls.Add(this.datevalue);
            this.Controls.Add(this.chequedatevalue);
            this.Controls.Add(this.chequenovalue);
            this.Controls.Add(this.ipscvalue);
            this.Controls.Add(this.bankaccountvalue);
            this.Controls.Add(this.banknamevalue);
            this.Controls.Add(this.paymentdescrptionvalue);
            this.Controls.Add(this.PAYOPTIONVALUE);
            this.Controls.Add(this.totalvaluetext);
            this.Controls.Add(this.VoucherNumber);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.InvoiceNo);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.gatdata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ChequeDate);
            this.Controls.Add(this.IPSC);
            this.Controls.Add(this.ChequeNo);
            this.Controls.Add(this.PaymentMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BankName);
            this.Controls.Add(this.PaymentDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VendorName);
            this.Name = "Collections";
            this.Text = "Collections";
            this.Load += new System.EventHandler(this.Collections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venderdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseentryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.ComboBox vendernamevalu;
        private System.Windows.Forms.BindingSource venderdetailsBindingSource;
   //     private masterDataSet7 masterDataSet7;
        private System.Windows.Forms.Button PAY;
        private System.Windows.Forms.TextBox discountvalue;
        private System.Windows.Forms.TextBox amountvalue;
        private System.Windows.Forms.TextBox invoicenumbervalue;
        private System.Windows.Forms.TextBox vouchernumbervalue;
        private System.Windows.Forms.DateTimePicker datevalue;
        private System.Windows.Forms.DateTimePicker chequedatevalue;
        private System.Windows.Forms.TextBox chequenovalue;
        private System.Windows.Forms.TextBox ipscvalue;
        private System.Windows.Forms.TextBox bankaccountvalue;
        private System.Windows.Forms.TextBox banknamevalue;
      //  private masterDataSet6TableAdapters.purchaseentryTableAdapter purchaseentryTableAdapter;
        private System.Windows.Forms.TextBox paymentdescrptionvalue;
        private System.Windows.Forms.BindingSource purchaseentryBindingSource;
       // private masterDataSet6 masterDataSet6;
        private System.Windows.Forms.ComboBox PAYOPTIONVALUE;
        private System.Windows.Forms.TextBox totalvaluetext;
        private System.Windows.Forms.Label VoucherNumber;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label InvoiceNo;
        private System.Windows.Forms.Label Discount;
       // private masterDataSet7TableAdapters.venderdetailsTableAdapter venderdetailsTableAdapter;
        private System.Windows.Forms.Button gatdata;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label ChequeDate;
        private System.Windows.Forms.Label IPSC;
        private System.Windows.Forms.Label ChequeNo;
        private System.Windows.Forms.Label PaymentMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BankName;
        private System.Windows.Forms.Label PaymentDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VendorName;
       // private masterDataSet8 masterDataSet8;
        private System.Windows.Forms.BindingSource venderdetailsBindingSource1;
        private vender vender;
        private System.Windows.Forms.BindingSource venderdetailsBindingSource2;
        private venderTableAdapters.venderdetailsTableAdapter venderdetailsTableAdapter;
        //private masterDataSet8TableAdapters.venderdetailsTableAdapter venderdetailsTableAdapter1;

    }
}