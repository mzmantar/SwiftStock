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
using SwiftStock.Views.SuperAdmin;
using DevExpress.DashboardCommon;
using SwiftStock.Views.Admin;

namespace SwiftStock.Views
{
    public partial class DashboardAdminForm : DevExpress.XtraEditors.XtraForm
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
        }
        private void LoadView(XtraUserControl view)
        {
            PanelContent.Controls.Clear();
            view.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(view);
        }
        private void DashbordButton_Click(object sender, EventArgs e)
        {
            LoadView(new DashboardHome());

        }
        private void ProduitandcategoriesButton_Click(object sender, EventArgs e)
        {
            LoadView(new ProductsandCategories());
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}