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
    public partial class ProductsandCategories : DevExpress.XtraEditors.XtraUserControl
    {
        public ProductsandCategories()
        {
            InitializeComponent();
        }

        private void diagramPanAndZoomControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashbordButton_Click(object sender, EventArgs e)
        {
            var addStockForm = new AddStock();
            addStockForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addListe = new ListeStock();
            addListe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var supp = new DropStock();
            supp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mod = new UpdateStock();
            mod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new Userandroles();
            user.Show();
        }
    }
}
