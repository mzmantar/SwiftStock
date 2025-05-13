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
using SwiftStock.Controllers;

namespace SwiftStock.Views.Admin
{
    public partial class ListeStock : DevExpress.XtraEditors.XtraForm
    {
        public ListeStock()
        {
            InitializeComponent();
            ProduitController produitController = new ProduitController();
            dataGridView1.DataSource = produitController.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}