namespace komal
{
    partial class Accounts
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addprodet = new System.Windows.Forms.Button();
            this.addvendor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(177, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 87);
            this.button4.TabIndex = 7;
            this.button4.Text = "Collection Ledger";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Olive;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(669, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 87);
            this.button3.TabIndex = 6;
            this.button3.Text = "Payment Ledger";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addprodet
            // 
            this.addprodet.BackColor = System.Drawing.Color.Lime;
            this.addprodet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addprodet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addprodet.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addprodet.ForeColor = System.Drawing.Color.Black;
            this.addprodet.Location = new System.Drawing.Point(338, 102);
            this.addprodet.Name = "addprodet";
            this.addprodet.Size = new System.Drawing.Size(178, 87);
            this.addprodet.TabIndex = 5;
            this.addprodet.Text = "Collections";
            this.addprodet.UseVisualStyleBackColor = false;
            this.addprodet.Click += new System.EventHandler(this.addprodet_Click);
            // 
            // addvendor
            // 
            this.addvendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addvendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addvendor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addvendor.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addvendor.ForeColor = System.Drawing.Color.Black;
            this.addvendor.Location = new System.Drawing.Point(12, 102);
            this.addvendor.Name = "addvendor";
            this.addvendor.Size = new System.Drawing.Size(178, 87);
            this.addvendor.TabIndex = 4;
            this.addvendor.Text = "Payments";
            this.addvendor.UseVisualStyleBackColor = false;
            this.addvendor.Click += new System.EventHandler(this.addvendor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(515, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 87);
            this.button1.TabIndex = 8;
            this.button1.Text = "Expences";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::komal.Properties.Resources.bank_reconcition1;
            this.ClientSize = new System.Drawing.Size(905, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addprodet);
            this.Controls.Add(this.addvendor);
            this.MaximizeBox = false;
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addprodet;
        private System.Windows.Forms.Button addvendor;
        private System.Windows.Forms.Button button1;
    }
}