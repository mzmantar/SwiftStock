using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class StockController
    {
        private readonly ApplicationDbContext _context;

        public StockController()
        {
            _context = new ApplicationDbContext();
        }

        public void AjouterMouvement(MouvementStock mouvement)
        {
            var produit = _context.Produits.FirstOrDefault(p => p.Id == mouvement.ProduitId);
            if (produit == null)
            {
                throw new Exception("Produit non trouvé");
            }

            if (mouvement.Type == TypeMouvement.Entree)
            {
                produit.QuantiteEnStock += mouvement.Quantite;
            }
            else if (mouvement.Type == TypeMouvement.Sortie)
            {
                if (produit.QuantiteEnStock < mouvement.Quantite)
                    throw new Exception("Stock insuffisant");

                produit.QuantiteEnStock -= mouvement.Quantite;
            }

            mouvement.DateMouvement = DateTime.Now;
            _context.MouvementsStock.Add(mouvement);
            _context.SaveChanges();
        }

        public List<MouvementStock> ListerMouvements()
        {
            return _context.MouvementsStock
                .OrderByDescending(m => m.DateMouvement)
                .ToList();
        }

        public List<MouvementStock> MouvementsParProduit(int produitId)
        {
            return _context.MouvementsStock
                .Where(m => m.ProduitId == produitId)
                .OrderByDescending(m => m.DateMouvement)
                .ToList();
        }
        public List<Produit> ObtenirDetailsStock()
        {
            return _context.Produits
                .Select(p => new Produit
                {
                    Id = p.Id,
                    Nom = p.Nom,
                    Description = p.Description,
                    QuantiteEnStock = p.QuantiteEnStock,
                    Prix = p.Prix,
                    Categorie = p.Categorie,
                    ImageUrl = p.ImageUrl
                })
                .ToList();
        }
    }
}
