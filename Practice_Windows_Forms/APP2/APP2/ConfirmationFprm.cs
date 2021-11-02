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
    public partial class ConfirmationFprm : Form
    {
        public ConfirmationFprm()
        {
            InitializeComponent();
        }

        private void fName_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmationFprm_Load(object sender, EventArgs e)
        {
            lbl_FName.Text = SignUp.FName;
            lbl_lName.Text = SignUp.LName;
            lbl_Mail.Text = SignUp.Email;

            if (SignUp.sms)
            {
                lblSMS.Text = "✔";
                lblSMS.ForeColor = Color.Green;
            }
            else
                lblSMS.ForeColor = Color.Red;

            if (SignUp.reports)
            {
                lblReports.Text = "✔";
                lblReports.ForeColor = Color.Green;
            }
            else
                lblReports.ForeColor = Color.Red;

            if (SignUp.transactions)
            {
                lblTransaction.Text = "✔";
                lblTransaction.ForeColor = Color.Green;
            }
            else
                lblTransaction.ForeColor = Color.Red;
        }
    }
}
