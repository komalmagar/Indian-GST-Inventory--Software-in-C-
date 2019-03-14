namespace komal
{
    partial class mytaxinvoice
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.sgstval = new System.Windows.Forms.TextBox();
            this.discvalu = new System.Windows.Forms.TextBox();
            this.afterdiscval = new System.Windows.Forms.TextBox();
            this.creditval = new System.Windows.Forms.TextBox();
            this.debitvaltaxvoice = new System.Windows.Forms.TextBox();
            this.gsttotalval = new System.Windows.Forms.TextBox();
            this.cgstval = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.igstval = new System.Windows.Forms.TextBox();
            this.subtotalval = new System.Windows.Forms.TextBox();
            this.totalvalue = new System.Windows.Forms.Label();
            this.IGST = new System.Windows.Forms.Label();
            this.SGST = new System.Windows.Forms.Label();
            this.CGST = new System.Windows.Forms.Label();
            this.gsttotal = new System.Windows.Forms.Label();
            this.Debitval = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.Label();
            this.afterdiscount = new System.Windows.Forms.Label();
            this.discval = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.discountval = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.invoicenoval = new System.Windows.Forms.TextBox();
            this.cashval = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InvoiceDate = new System.Windows.Forms.Label();
            this.Invoiceno = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.freeqyt = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.ratevalue = new System.Windows.Forms.Label();
            this.prcode = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.Cash1 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.ADDRESS = new System.Windows.Forms.Label();
            this.TO = new System.Windows.Forms.Label();
            this.customer1 = new komal.customer1();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new komal.customer1TableAdapters.customerTableAdapter();
            this.productname1 = new komal.productname();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new komal.productnameTableAdapters.productTableAdapter();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1126, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 134;
            this.button1.Text = "ViewAll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customerBindingSource1;
            this.comboBox1.DisplayMember = "customername";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 21);
            this.comboBox1.TabIndex = 124;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            // 
            // textBox7
            // 
            this.textBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox7.Location = new System.Drawing.Point(773, 690);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox7.Size = new System.Drawing.Size(147, 20);
            this.textBox7.TabIndex = 123;
            this.textBox7.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(926, 693);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Rupees";
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DELETE.Location = new System.Drawing.Point(1124, 427);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(86, 32);
            this.DELETE.TabIndex = 121;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(1126, 389);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(86, 32);
            this.UPDATE.TabIndex = 120;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ADD.Location = new System.Drawing.Point(1126, 351);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(84, 32);
            this.ADD.TabIndex = 119;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // sgstval
            // 
            this.sgstval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sgstval.Location = new System.Drawing.Point(773, 608);
            this.sgstval.Name = "sgstval";
            this.sgstval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sgstval.Size = new System.Drawing.Size(147, 20);
            this.sgstval.TabIndex = 112;
            this.sgstval.Text = "0.00";
            // 
            // discvalu
            // 
            this.discvalu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.discvalu.Location = new System.Drawing.Point(327, 557);
            this.discvalu.Name = "discvalu";
            this.discvalu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discvalu.Size = new System.Drawing.Size(147, 20);
            this.discvalu.TabIndex = 118;
            this.discvalu.Text = "0.00";
            // 
            // afterdiscval
            // 
            this.afterdiscval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.afterdiscval.Location = new System.Drawing.Point(327, 605);
            this.afterdiscval.Name = "afterdiscval";
            this.afterdiscval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.afterdiscval.Size = new System.Drawing.Size(147, 20);
            this.afterdiscval.TabIndex = 117;
            this.afterdiscval.Text = "0.00";
            // 
            // creditval
            // 
            this.creditval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.creditval.Location = new System.Drawing.Point(327, 649);
            this.creditval.Name = "creditval";
            this.creditval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creditval.Size = new System.Drawing.Size(147, 20);
            this.creditval.TabIndex = 116;
            this.creditval.Text = "0.00";
            // 
            // debitvaltaxvoice
            // 
            this.debitvaltaxvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.debitvaltaxvoice.Location = new System.Drawing.Point(327, 690);
            this.debitvaltaxvoice.Name = "debitvaltaxvoice";
            this.debitvaltaxvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.debitvaltaxvoice.Size = new System.Drawing.Size(147, 20);
            this.debitvaltaxvoice.TabIndex = 115;
            this.debitvaltaxvoice.Text = "0.00";
            // 
            // gsttotalval
            // 
            this.gsttotalval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gsttotalval.Location = new System.Drawing.Point(773, 507);
            this.gsttotalval.Name = "gsttotalval";
            this.gsttotalval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gsttotalval.Size = new System.Drawing.Size(147, 20);
            this.gsttotalval.TabIndex = 114;
            this.gsttotalval.Text = "0.00";
            // 
            // cgstval
            // 
            this.cgstval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cgstval.Location = new System.Drawing.Point(773, 560);
            this.cgstval.Name = "cgstval";
            this.cgstval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cgstval.Size = new System.Drawing.Size(147, 20);
            this.cgstval.TabIndex = 113;
            this.cgstval.Text = "0.00";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(298, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 13);
            this.linkLabel1.TabIndex = 133;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "More Details";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(526, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 132;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(526, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "Free";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Total QTY";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.productBindingSource1;
            this.comboBox2.DisplayMember = "productname";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 266);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(325, 21);
            this.comboBox2.TabIndex = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.productBindingSource2;
            this.comboBox5.DisplayMember = "productcode";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(444, 264);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(107, 21);
            this.comboBox5.TabIndex = 128;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.customerBindingSource1;
            this.comboBox4.DisplayMember = "address";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(216, 51);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 3, 6, 6);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(428, 21);
            this.comboBox4.TabIndex = 127;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.customerBindingSource1;
            this.comboBox3.DisplayMember = "taluka";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(216, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(291, 21);
            this.comboBox3.TabIndex = 126;
            // 
            // igstval
            // 
            this.igstval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.igstval.Location = new System.Drawing.Point(773, 649);
            this.igstval.Name = "igstval";
            this.igstval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.igstval.Size = new System.Drawing.Size(147, 20);
            this.igstval.TabIndex = 111;
            this.igstval.Text = "0.00";
            // 
            // subtotalval
            // 
            this.subtotalval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.subtotalval.Location = new System.Drawing.Point(327, 507);
            this.subtotalval.Name = "subtotalval";
            this.subtotalval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subtotalval.Size = new System.Drawing.Size(147, 20);
            this.subtotalval.TabIndex = 110;
            this.subtotalval.Text = "0.00";
            // 
            // totalvalue
            // 
            this.totalvalue.AutoSize = true;
            this.totalvalue.Location = new System.Drawing.Point(625, 690);
            this.totalvalue.Name = "totalvalue";
            this.totalvalue.Size = new System.Drawing.Size(64, 13);
            this.totalvalue.TabIndex = 109;
            this.totalvalue.Text = "Total  Value";
            // 
            // IGST
            // 
            this.IGST.AutoSize = true;
            this.IGST.Location = new System.Drawing.Point(625, 649);
            this.IGST.Name = "IGST";
            this.IGST.Size = new System.Drawing.Size(32, 13);
            this.IGST.TabIndex = 108;
            this.IGST.Text = "IGST";
            // 
            // SGST
            // 
            this.SGST.AutoSize = true;
            this.SGST.Location = new System.Drawing.Point(625, 608);
            this.SGST.Name = "SGST";
            this.SGST.Size = new System.Drawing.Size(36, 13);
            this.SGST.TabIndex = 107;
            this.SGST.Text = "SGST";
            // 
            // CGST
            // 
            this.CGST.AutoSize = true;
            this.CGST.Location = new System.Drawing.Point(625, 563);
            this.CGST.Name = "CGST";
            this.CGST.Size = new System.Drawing.Size(36, 13);
            this.CGST.TabIndex = 106;
            this.CGST.Text = "CGST";
            // 
            // gsttotal
            // 
            this.gsttotal.AutoSize = true;
            this.gsttotal.Location = new System.Drawing.Point(625, 513);
            this.gsttotal.Name = "gsttotal";
            this.gsttotal.Size = new System.Drawing.Size(59, 13);
            this.gsttotal.TabIndex = 105;
            this.gsttotal.Text = "GST  Total";
            // 
            // Debitval
            // 
            this.Debitval.AutoSize = true;
            this.Debitval.Location = new System.Drawing.Point(215, 690);
            this.Debitval.Name = "Debitval";
            this.Debitval.Size = new System.Drawing.Size(32, 13);
            this.Debitval.TabIndex = 104;
            this.Debitval.Text = "Debit";
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(215, 649);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(34, 13);
            this.Credit.TabIndex = 103;
            this.Credit.Text = "Credit";
            // 
            // afterdiscount
            // 
            this.afterdiscount.AutoSize = true;
            this.afterdiscount.Location = new System.Drawing.Point(215, 608);
            this.afterdiscount.Name = "afterdiscount";
            this.afterdiscount.Size = new System.Drawing.Size(53, 13);
            this.afterdiscount.TabIndex = 102;
            this.afterdiscount.Text = "After Disc";
            // 
            // discval
            // 
            this.discval.AutoSize = true;
            this.discval.Location = new System.Drawing.Point(215, 563);
            this.discval.Name = "discval";
            this.discval.Size = new System.Drawing.Size(46, 13);
            this.discval.TabIndex = 101;
            this.discval.Text = "Disc Val";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(215, 513);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(56, 13);
            this.subtotal.TabIndex = 100;
            this.subtotal.Text = "Sub  Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 169);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // discountval
            // 
            this.discountval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.discountval.Location = new System.Drawing.Point(1067, 266);
            this.discountval.Name = "discountval";
            this.discountval.Size = new System.Drawing.Size(113, 20);
            this.discountval.TabIndex = 98;
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox5.Location = new System.Drawing.Point(930, 266);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(113, 20);
            this.textBox5.TabIndex = 97;
            this.textBox5.Text = "0.00";
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.Location = new System.Drawing.Point(766, 266);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 96;
            this.textBox4.Text = "0.00";
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.Location = new System.Drawing.Point(617, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 95;
            this.textBox3.Text = "0.00";
            // 
            // invoicenoval
            // 
            this.invoicenoval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicenoval.Location = new System.Drawing.Point(912, 10);
            this.invoicenoval.Name = "invoicenoval";
            this.invoicenoval.Size = new System.Drawing.Size(200, 20);
            this.invoicenoval.TabIndex = 94;
            // 
            // cashval
            // 
            this.cashval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cashval.Location = new System.Drawing.Point(216, 152);
            this.cashval.Name = "cashval";
            this.cashval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cashval.Size = new System.Drawing.Size(107, 20);
            this.cashval.TabIndex = 93;
            this.cashval.Text = "0.00";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(912, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 92;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AutoSize = true;
            this.InvoiceDate.Location = new System.Drawing.Point(793, 75);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(68, 13);
            this.InvoiceDate.TabIndex = 91;
            this.InvoiceDate.Text = "Invoice Date";
            // 
            // Invoiceno
            // 
            this.Invoiceno.AutoSize = true;
            this.Invoiceno.Location = new System.Drawing.Point(793, 13);
            this.Invoiceno.Name = "Invoiceno";
            this.Invoiceno.Size = new System.Drawing.Size(59, 13);
            this.Invoiceno.TabIndex = 90;
            this.Invoiceno.Text = "Invoice No";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(1075, 243);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(63, 13);
            this.discount.TabIndex = 89;
            this.discount.Text = "Discount  %";
            // 
            // freeqyt
            // 
            this.freeqyt.AutoSize = true;
            this.freeqyt.Location = new System.Drawing.Point(926, 243);
            this.freeqyt.Name = "freeqyt";
            this.freeqyt.Size = new System.Drawing.Size(53, 13);
            this.freeqyt.TabIndex = 88;
            this.freeqyt.Text = "Free  Qty.";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(769, 243);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 87;
            this.Quantity.Text = "Quantity";
            // 
            // ratevalue
            // 
            this.ratevalue.AutoSize = true;
            this.ratevalue.Location = new System.Drawing.Point(613, 243);
            this.ratevalue.Name = "ratevalue";
            this.ratevalue.Size = new System.Drawing.Size(60, 13);
            this.ratevalue.TabIndex = 86;
            this.ratevalue.Text = "Rate Value";
            // 
            // prcode
            // 
            this.prcode.AutoSize = true;
            this.prcode.Location = new System.Drawing.Point(455, 241);
            this.prcode.Name = "prcode";
            this.prcode.Size = new System.Drawing.Size(48, 13);
            this.prcode.TabIndex = 85;
            this.prcode.Text = "Pr  Code";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(122, 243);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(78, 13);
            this.ProductName.TabIndex = 84;
            this.ProductName.Text = "Product  Name";
            // 
            // Cash1
            // 
            this.Cash1.AutoSize = true;
            this.Cash1.Location = new System.Drawing.Point(133, 158);
            this.Cash1.Name = "Cash1";
            this.Cash1.Size = new System.Drawing.Size(31, 13);
            this.Cash1.TabIndex = 83;
            this.Cash1.Text = "Cash";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(136, 111);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(29, 13);
            this.Area.TabIndex = 82;
            this.Area.Text = "Area";
            // 
            // ADDRESS
            // 
            this.ADDRESS.AutoSize = true;
            this.ADDRESS.Location = new System.Drawing.Point(122, 51);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(45, 13);
            this.ADDRESS.TabIndex = 81;
            this.ADDRESS.Text = "Address";
            // 
            // TO
            // 
            this.TO.AutoSize = true;
            this.TO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TO.Location = new System.Drawing.Point(117, 1);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(43, 25);
            this.TO.TabIndex = 80;
            this.TO.Text = "TO";
            // 
            // customer1
            // 
            this.customer1.DataSetName = "customer1";
            this.customer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.customer1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // productname1
            // 
            this.productname1.DataSetName = "productname";
            this.productname1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.productname1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "product";
            this.productBindingSource2.DataSource = this.productname1;
            // 
            // mytaxinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.sgstval);
            this.Controls.Add(this.discvalu);
            this.Controls.Add(this.afterdiscval);
            this.Controls.Add(this.creditval);
            this.Controls.Add(this.debitvaltaxvoice);
            this.Controls.Add(this.gsttotalval);
            this.Controls.Add(this.cgstval);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.igstval);
            this.Controls.Add(this.subtotalval);
            this.Controls.Add(this.totalvalue);
            this.Controls.Add(this.IGST);
            this.Controls.Add(this.SGST);
            this.Controls.Add(this.CGST);
            this.Controls.Add(this.gsttotal);
            this.Controls.Add(this.Debitval);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.afterdiscount);
            this.Controls.Add(this.discval);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.discountval);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.invoicenoval);
            this.Controls.Add(this.cashval);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.Invoiceno);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.freeqyt);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ratevalue);
            this.Controls.Add(this.prcode);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Cash1);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.TO);
            this.Name = "mytaxinvoice";
            this.Text = "mytaxinvoice";
            this.Load += new System.EventHandler(this.mytaxinvoice_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productname1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource customerBindingSource;
      //  private masterDataSet3 masterDataSet3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox sgstval;
        private System.Windows.Forms.TextBox discvalu;
        private System.Windows.Forms.TextBox afterdiscval;
        private System.Windows.Forms.TextBox creditval;
        private System.Windows.Forms.TextBox debitvaltaxvoice;
        private System.Windows.Forms.TextBox gsttotalval;
        private System.Windows.Forms.TextBox cgstval;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource productBindingSource;
        //private masterDataSet4 masterDataSet4;
    //    private masterDataSet4TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
      //  private masterDataSet3TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox igstval;
        private System.Windows.Forms.TextBox subtotalval;
        private System.Windows.Forms.Label totalvalue;
        private System.Windows.Forms.Label IGST;
        private System.Windows.Forms.Label SGST;
        private System.Windows.Forms.Label CGST;
        private System.Windows.Forms.Label gsttotal;
        private System.Windows.Forms.Label Debitval;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.Label afterdiscount;
        private System.Windows.Forms.Label discval;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox discountval;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox invoicenoval;
        private System.Windows.Forms.TextBox cashval;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label InvoiceDate;
        private System.Windows.Forms.Label Invoiceno;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label freeqyt;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label ratevalue;
        private System.Windows.Forms.Label prcode;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Cash1;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label ADDRESS;
        private System.Windows.Forms.Label TO;
        private customer1 customer1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private customer1TableAdapters.customerTableAdapter customerTableAdapter;
        private productname productname1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private productnameTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource2;

    }
}