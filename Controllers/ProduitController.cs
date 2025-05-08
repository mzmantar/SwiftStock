using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class ProduitController
    {
        private readonly ApplicationDbContext _context;

        public ProduitController()
        {
            _context = new ApplicationDbContext();
        }

        public List<Produit> GetAll()
        {
            return _context.Produits.ToList();
        }

        public Produit GetById(int id)
        {
            return _context.Produits.FirstOrDefault(p => p.Id == id);
        }
        public void AddProduit(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
        }
        public void ModifierProduit(Produit produit)
        {
            var existing = _context.Produits.Find(produit.Id);
            if (existing != null)
            {
                existing.Nom = produit.Nom;
                existing.Prix = produit.Prix;
                existing.Description = produit.Description;
                existing.QuantiteEnStock = produit.QuantiteEnStock;
                existing.Categorie = produit.Categorie;
                existing.ImageUrl = produit.ImageUrl;
                existing.categoryId = produit.categoryId;
                _context.Produits.Update(existing);
                _context.SaveChanges();
            }
        }
        public void SupprimerProduit(int id)
        {
            var produit = _context.Produits.Find(id);
            if (produit != null)
            {
                _context.Produits.Remove(produit);
                _context.SaveChanges();
            }
        }


    }
}
