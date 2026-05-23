using System;
using System.Drawing;
using System.Windows.Forms;
using UserNamespace;

namespace InheritancePolymorphism
{
    public partial class Form1 : Form
    {
        private Administrator systemAdmin = new Administrator("Harvey", "admin1", "password123");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputId = txtUserId.Text;
            string inputPass = txtPassword.Text;

            if (btnLogin.Text == "Authenticate")
            {
                bool isAuthenticated = systemAdmin.verifyLogin(inputId, inputPass);

                if (isAuthenticated)
                {
                    MessageDialog.ShowBox("Access Granted", "Welcome back.\nPlease update your default password to continue.");

                    lblSystemLogin.Text = "Update Password";
                    txtUserId.Enabled = false; 
                    txtPassword.Text = "";     
                    txtPassword.Hint = "Enter New Password";
                    btnLogin.Text = "Save New Password";
                }
                else
                {
                    MessageDialog.ShowBox("Access Denied", "Invalid Credentials.\nPlease check your ID and Password.");
                }
            }
            else if (btnLogin.Text == "Save New Password")
            {
                if (string.IsNullOrWhiteSpace(inputPass))
                {
                    MessageDialog.ShowBox("Error", "Password cannot be blank.");
                    return;
                }

                systemAdmin.updatePassword(inputPass);

                MessageDialog.ShowBox("System Message", "Your password has been successfully updated!");

                lblSystemLogin.Text = "System Login";
                txtUserId.Enabled = true;
                txtPassword.Text = "";
                txtPassword.Hint = "Password";
                btnLogin.Text = "Authenticate";
            }
        }
    }
}