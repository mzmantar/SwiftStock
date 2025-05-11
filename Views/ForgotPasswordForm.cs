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
using SwiftStock.Controllers;

namespace SwiftStock.Views
{
    public partial class ForgotPasswordForm : DevExpress.XtraEditors.XtraForm
    {
        String UserRest = "";
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            UserRest = UsernameBox.Text;
        }

        private void ResetPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserRest))
            {
                labelAlert.Text = "Please enter your username!";
                return;
            }

            var controller = new DemandeResetPasswordController();
            bool resultat = controller.CreerDemande(UserRest);

            if (resultat)
                labelAlert.Text = "A response will be sent as soon as possible.";
            else
                labelAlert.Text = "A request already exists or the username does not exist.";
        }

        private void BackLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
