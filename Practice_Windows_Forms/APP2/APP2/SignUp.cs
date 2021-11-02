using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP2
{
    public partial class SignUp : Form
    {
        public static string FName;
        public static string LName;
        public static string Email;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;
        ConfirmationFprm c = new ConfirmationFprm();

        public SignUp()
        {
            InitializeComponent();
        }

        private void smsChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(smsChbox.Checked)
            {
                sms = true;
                SMSmsgLabel.Text = "All services applied for SMS";
            }

            else
            {
                sms = false;
                SMSmsgLabel.Text = "......";
            }
        }

        private void repChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (repChBox.Checked)
                reports = true;
            
            else
                reports = false;
            
        }

        private void TransRepChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TransRepChBox.Checked)
            {
               transactions = true;
                TransmsgLabel.Text = "All services applied for SMS";
            }

            else
            {
                transactions = false;
                TransmsgLabel.Text = "......";
            }
        }

        private void signUpbtn_Click(object sender, EventArgs e)
        {
            FName = txtFname.Text;
            LName = txtLname.Text;
            Email = txtMail.Text;
            this.Hide();
            c.Show();
        }
    }
}
