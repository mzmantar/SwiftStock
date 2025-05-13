using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SwiftStock.Views.Admin
{
    public partial class DashboardHome : DevExpress.XtraEditors.XtraUserControl
    {
        public DashboardHome()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Récupère la ligne cliquée
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Affiche les valeurs
                string id = row.Cells["colID"].Value.ToString();
                string nom = row.Cells["colNom"].Value.ToString();
                string prix = row.Cells["colPrix"].Value.ToString();

                MessageBox.Show($"ID: {id}\nNom: {nom}\nPrix: {prix}", "Détail de l'article");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
