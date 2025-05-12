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
using DevExpress.XtraBars.Navigation;
using SwiftStock.Views.SuperAdmin;


namespace SwiftStock.Views
{
    public partial class Sidebar : DevExpress.XtraEditors.XtraForm
    {

        public Sidebar()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {

            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }
        private void LoadView(XtraUserControl view)
        {
            PanelContent.Controls.Clear();
            view.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(view);
        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeUserControl = new HomeUserControl();
            LoadView(homeUserControl);
        }

        private void UserMangement_Click(object sender, EventArgs e)
        {
            var userManagementUserControl = new UserManagementUserControl();
            LoadView(userManagementUserControl);

        }

        private void PasswordRestButton_Click(object sender, EventArgs e)
        {
            var passwordResetUserControl = new PasswordResetUserControl();
            LoadView(passwordResetUserControl);

        }

        private void SatisticsButton_Click(object sender, EventArgs e)
        {
            var statisticsUserControl = new StatisticsUserControl();
            LoadView(statisticsUserControl);
        }

        private void SystemlogsButton_Click(object sender, EventArgs e)
        {
            var systemLogsUserControl = new SystemLogsUserControl();
            LoadView(systemLogsUserControl);

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsUserControl = new SettingsUserControl();
            LoadView(settingsUserControl);

        }
        private void LabSwiftStock_Click(object sender, EventArgs e)
        {
            
            var homeUserControl = new HomeUserControl();
            LoadView(homeUserControl);

        }
    }


}
