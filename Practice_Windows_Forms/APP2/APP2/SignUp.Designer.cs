
namespace APP2
{
    partial class SignUp
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
            this.txtFname = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TransmsgLabel = new System.Windows.Forms.Label();
            this.SMSmsgLabel = new System.Windows.Forms.Label();
            this.TransRepChBox = new System.Windows.Forms.CheckBox();
            this.repChBox = new System.Windows.Forms.CheckBox();
            this.smsChbox = new System.Windows.Forms.CheckBox();
            this.signUpbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(256, 39);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(704, 22);
            this.txtFname.TabIndex = 1;
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(47, 30);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(152, 31);
            this.fName.TabIndex = 2;
            this.fName.Text = "First Name:";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(47, 134);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(180, 31);
            this.mail.TabIndex = 4;
            this.mail.Text = "Email Addres:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(256, 143);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(704, 22);
            this.txtMail.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(47, 83);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(149, 31);
            this.lName.TabIndex = 6;
            this.lName.Text = "Last Name:";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(256, 92);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(704, 22);
            this.txtLname.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TransmsgLabel);
            this.groupBox1.Controls.Add(this.SMSmsgLabel);
            this.groupBox1.Controls.Add(this.TransRepChBox);
            this.groupBox1.Controls.Add(this.repChBox);
            this.groupBox1.Controls.Add(this.smsChbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 198);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // TransmsgLabel
            // 
            this.TransmsgLabel.AutoSize = true;
            this.TransmsgLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmsgLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.TransmsgLabel.Location = new System.Drawing.Point(550, 142);
            this.TransmsgLabel.Name = "TransmsgLabel";
            this.TransmsgLabel.Size = new System.Drawing.Size(42, 26);
            this.TransmsgLabel.TabIndex = 4;
            this.TransmsgLabel.Text = "......";
            // 
            // SMSmsgLabel
            // 
            this.SMSmsgLabel.AutoSize = true;
            this.SMSmsgLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMSmsgLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.SMSmsgLabel.Location = new System.Drawing.Point(550, 50);
            this.SMSmsgLabel.Name = "SMSmsgLabel";
            this.SMSmsgLabel.Size = new System.Drawing.Size(42, 26);
            this.SMSmsgLabel.TabIndex = 3;
            this.SMSmsgLabel.Text = "......";
            // 
            // TransRepChBox
            // 
            this.TransRepChBox.AutoSize = true;
            this.TransRepChBox.Location = new System.Drawing.Point(197, 138);
            this.TransRepChBox.Name = "TransRepChBox";
            this.TransRepChBox.Size = new System.Drawing.Size(280, 35);
            this.TransRepChBox.TabIndex = 2;
            this.TransRepChBox.Text = "Transaction Reports";
            this.TransRepChBox.UseVisualStyleBackColor = true;
            this.TransRepChBox.CheckedChanged += new System.EventHandler(this.TransRepChBox_CheckedChanged);
            // 
            // repChBox
            // 
            this.repChBox.AutoSize = true;
            this.repChBox.Location = new System.Drawing.Point(197, 97);
            this.repChBox.Name = "repChBox";
            this.repChBox.Size = new System.Drawing.Size(131, 35);
            this.repChBox.TabIndex = 1;
            this.repChBox.Text = "Reports";
            this.repChBox.UseVisualStyleBackColor = true;
            this.repChBox.CheckedChanged += new System.EventHandler(this.repChBox_CheckedChanged);
            // 
            // smsChbox
            // 
            this.smsChbox.AutoSize = true;
            this.smsChbox.Location = new System.Drawing.Point(197, 46);
            this.smsChbox.Name = "smsChbox";
            this.smsChbox.Size = new System.Drawing.Size(246, 35);
            this.smsChbox.TabIndex = 0;
            this.smsChbox.Text = "SMS Notfications";
            this.smsChbox.UseVisualStyleBackColor = true;
            this.smsChbox.CheckedChanged += new System.EventHandler(this.smsChbox_CheckedChanged);
            // 
            // signUpbtn
            // 
            this.signUpbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpbtn.Location = new System.Drawing.Point(438, 430);
            this.signUpbtn.Name = "signUpbtn";
            this.signUpbtn.Size = new System.Drawing.Size(149, 48);
            this.signUpbtn.TabIndex = 9;
            this.signUpbtn.Text = "Sign Up";
            this.signUpbtn.UseVisualStyleBackColor = true;
            this.signUpbtn.Click += new System.EventHandler(this.signUpbtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 490);
            this.Controls.Add(this.signUpbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.txtFname);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox TransRepChBox;
        private System.Windows.Forms.CheckBox repChBox;
        private System.Windows.Forms.CheckBox smsChbox;
        private System.Windows.Forms.Label SMSmsgLabel;
        private System.Windows.Forms.Label TransmsgLabel;
        private System.Windows.Forms.Button signUpbtn;
    }
}

