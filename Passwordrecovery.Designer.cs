namespace komal
{
    partial class Passwordrecovery
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
            this.label1 = new System.Windows.Forms.Label();
            this.USER = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernamevalue = new System.Windows.Forms.TextBox();
            this.oldpasswordvalue = new System.Windows.Forms.TextBox();
            this.newpasswordvalue = new System.Windows.Forms.TextBox();
            this.confirmedpasswordvalue = new System.Windows.Forms.TextBox();
            this.changebuttonvalue = new System.Windows.Forms.Button();
            this.exitbuttonvalue = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PASSWORD CHANGE";
            // 
            // USER
            // 
            this.USER.AutoSize = true;
            this.USER.Location = new System.Drawing.Point(56, 124);
            this.USER.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(109, 20);
            this.USER.TabIndex = 1;
            this.USER.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "OLD PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NEW PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONFIRMED PASSWORD";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // usernamevalue
            // 
            this.usernamevalue.Location = new System.Drawing.Point(330, 118);
            this.usernamevalue.Margin = new System.Windows.Forms.Padding(5);
            this.usernamevalue.Name = "usernamevalue";
            this.usernamevalue.Size = new System.Drawing.Size(164, 26);
            this.usernamevalue.TabIndex = 5;
            // 
            // oldpasswordvalue
            // 
            this.oldpasswordvalue.Location = new System.Drawing.Point(330, 190);
            this.oldpasswordvalue.Margin = new System.Windows.Forms.Padding(5);
            this.oldpasswordvalue.Name = "oldpasswordvalue";
            this.oldpasswordvalue.PasswordChar = '*';
            this.oldpasswordvalue.Size = new System.Drawing.Size(164, 26);
            this.oldpasswordvalue.TabIndex = 6;
            this.oldpasswordvalue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // newpasswordvalue
            // 
            this.newpasswordvalue.Location = new System.Drawing.Point(330, 262);
            this.newpasswordvalue.Margin = new System.Windows.Forms.Padding(5);
            this.newpasswordvalue.Name = "newpasswordvalue";
            this.newpasswordvalue.PasswordChar = '*';
            this.newpasswordvalue.Size = new System.Drawing.Size(164, 26);
            this.newpasswordvalue.TabIndex = 7;
            this.newpasswordvalue.UseSystemPasswordChar = true;
            // 
            // confirmedpasswordvalue
            // 
            this.confirmedpasswordvalue.Location = new System.Drawing.Point(330, 340);
            this.confirmedpasswordvalue.Margin = new System.Windows.Forms.Padding(5);
            this.confirmedpasswordvalue.Name = "confirmedpasswordvalue";
            this.confirmedpasswordvalue.PasswordChar = '*';
            this.confirmedpasswordvalue.Size = new System.Drawing.Size(164, 26);
            this.confirmedpasswordvalue.TabIndex = 8;
            // 
            // changebuttonvalue
            // 
            this.changebuttonvalue.Location = new System.Drawing.Point(127, 412);
            this.changebuttonvalue.Margin = new System.Windows.Forms.Padding(5);
            this.changebuttonvalue.Name = "changebuttonvalue";
            this.changebuttonvalue.Size = new System.Drawing.Size(125, 35);
            this.changebuttonvalue.TabIndex = 9;
            this.changebuttonvalue.Text = "CHANGE";
            this.changebuttonvalue.UseVisualStyleBackColor = true;
            this.changebuttonvalue.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbuttonvalue
            // 
            this.exitbuttonvalue.Location = new System.Drawing.Point(440, 412);
            this.exitbuttonvalue.Margin = new System.Windows.Forms.Padding(5);
            this.exitbuttonvalue.Name = "exitbuttonvalue";
            this.exitbuttonvalue.Size = new System.Drawing.Size(125, 35);
            this.exitbuttonvalue.TabIndex = 10;
            this.exitbuttonvalue.Text = "EXIT";
            this.exitbuttonvalue.UseVisualStyleBackColor = true;
            this.exitbuttonvalue.Click += new System.EventHandler(this.exitbuttonvalue_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Passwordrecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 466);
            this.Controls.Add(this.exitbuttonvalue);
            this.Controls.Add(this.changebuttonvalue);
            this.Controls.Add(this.confirmedpasswordvalue);
            this.Controls.Add(this.newpasswordvalue);
            this.Controls.Add(this.oldpasswordvalue);
            this.Controls.Add(this.usernamevalue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.USER);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Passwordrecovery";
            this.Text = "Passwordrecovery";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernamevalue;
        private System.Windows.Forms.TextBox oldpasswordvalue;
        private System.Windows.Forms.TextBox newpasswordvalue;
        private System.Windows.Forms.TextBox confirmedpasswordvalue;
        private System.Windows.Forms.Button changebuttonvalue;
        private System.Windows.Forms.Button exitbuttonvalue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}