using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using SwiftStock.Controllers;

namespace SwiftStock.Views
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        String user = "";
        String pass = "";

        private readonly AuthController _authController;
        public LoginForm()
        {
            InitializeComponent();
            PasswordBox.UseSystemPasswordChar = true;

            _authController = new AuthController();
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            user = UsernameBox.Text;
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            pass = PasswordBox.Text;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user))
            {
                label3.Text = "Please enter your username!";
            }
            else if (string.IsNullOrEmpty(pass))
            {
                label3.Text = "Please enter your password!";
            }
            else
            {
                var utilisateur = _authController.SignIn(user, pass);

                if (utilisateur != null)
                {
                    label3.Text = "Login successful!";
                    this.Hide();
                    switch (utilisateur.TypeUtilisateur.ToString().ToLower())
                    {
                        case "superadmin":
                            var superAdminForm = new Sidebar();
                            superAdminForm.Show();
                            break;

                        case "admin":
                            var adminForm = new DashboardAdminForm();
                            adminForm.Show();
                            break;

                        case "client":
                            var clientForm = new DashboardClientForm();
                            clientForm.Show();
                            break;

                        default:
                            MessageBox.Show("Unknown role. Contact the administrator.");
                            this.Show();
                            break;
                    }
                }
                else
                {
                    label3.Text = "Invalid username or password!";
                }
            }
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            var forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}