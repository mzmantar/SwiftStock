using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SwiftStock.Controllers;
using SwiftStock.Models;

namespace SwiftStock.Views.Admin
{
    public partial class AddStock : DevExpress.XtraEditors.XtraForm
    {
        private readonly ProduitController _produitController;
        private readonly CategorieController _categoryController;
        private readonly ErrorProvider errorProvider;

        public AddStock()
        {
            InitializeComponent();
            _produitController = new ProduitController();
            errorProvider = new ErrorProvider();
            _categoryController = new CategorieController();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            // Initialisation des éléments au chargement du formulaire si nécessaire.
        }

        private void NomBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomBox.Text))
            {
                errorProvider.SetError(NomBox, "Le nom du produit ne peut pas être vide.");
            }
            else
            {
                errorProvider.SetError(NomBox, "");
            }
        }

        private void PrixBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(PrixBox.Text, out decimal prix))
            {
                if (prix <= 0)
                {
                    errorProvider.SetError(PrixBox, "Le prix doit être supérieur à zéro.");
                }
                else
                {
                    errorProvider.SetError(PrixBox, "");
                }
            }
            else if (!string.IsNullOrWhiteSpace(PrixBox.Text))
            {
                errorProvider.SetError(PrixBox, "Le prix n'est pas valide.");
            }
            else
            {
                errorProvider.SetError(PrixBox, "");
            }
        }

        private void QuantiteBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(QuantiteBox1.Text, out int quantite))
            {
                if (quantite < 0)
                {
                    errorProvider.SetError(QuantiteBox1, "La quantité ne peut pas être négative.");
                }
                else
                {
                    errorProvider.SetError(QuantiteBox1, "");
                }
            }
            else if (!string.IsNullOrWhiteSpace(QuantiteBox1.Text))
            {
                errorProvider.SetError(QuantiteBox1, "La quantité n'est pas valide.");
            }
            else
            {
                errorProvider.SetError(QuantiteBox1, "");
            }
        }

        private void CategorieBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategorieBox1.Text))
            {
                errorProvider.SetError(CategorieBox1, "La catégorie ne peut pas être vide.");
            }
            else
            {
                errorProvider.SetError(CategorieBox1, "");
            }
        }

        private void DescriptionBox1_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionBox1.Text.Length < 10)
            {
                errorProvider.SetError(DescriptionBox1, "La description doit contenir au moins 10 caractères.");
            }
            else
            {
                errorProvider.SetError(DescriptionBox1, "");
            }
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            string nom = NomBox.Text;
            decimal prix;
            if (!decimal.TryParse(PrixBox.Text, out prix))
            {
                MessageBox.Show("Le prix n'est pas valide.");
                return;
            }

            int quantite;
            if (!int.TryParse(QuantiteBox1.Text, out quantite))
            {
                MessageBox.Show("La quantité n'est pas valide.");
                return;
            }

            string categorie = CategorieBox1.Text;
            string description = DescriptionBox1.Text;

            // Création du produit sans erreurs de syntaxe
            var produit = new Produit
            {
                Nom = nom,
                Prix = prix,
                QuantiteEnStock = quantite,
                Categorie = "w",
                Description = description,
                ImageUrl = "default.png",

            };

            produit.categoryId = _categoryController.GetAllCategories()[0].Id;

            _produitController.AddProduit(produit);
            MessageBox.Show("Produit ajouté avec succès.");
            this.Close();
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
