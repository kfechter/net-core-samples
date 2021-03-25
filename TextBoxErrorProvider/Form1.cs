using Extensions;
using System;
using System.Windows.Forms;

namespace TextBoxErrorProvider
{
    public partial class Form1 : Form
    {
        private string ValidationUsername => "user";
        private string ValidationPassword => "pass";

        private string UsernameValidationMessage => "Username incorrect";
        private string PasswordValidationMessage => "Password is incorrect, check caps lock and try password again";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.IsEqual(ValidationUsername) && txtPassword.Text.IsEqual(ValidationPassword))
            {
                erprovUsername.Clear();
                erprovPassword.Clear();
                btnValidate.Enabled = true;
            }
            else
            {
                btnValidate.Enabled = false;
                if(!txtUsername.Text.IsEqual(ValidationUsername))
                {
                    erprovUsername.SetError(txtUsername, UsernameValidationMessage);
                }
                else
                {
                    erprovUsername.Clear();
                }


                if (!txtPassword.Text.IsEqual(ValidationPassword))
                {
                    erprovPassword.SetError(txtPassword, PasswordValidationMessage);
                }
                else
                {
                    erprovPassword.Clear();
                }
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome, you are now logged in.");
            Close();
        }
    }
}
