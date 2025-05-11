using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class DetailCommandeController
    {
        private readonly ApplicationDbContext _context;

        public DetailCommandeController()
        {
            _context = new ApplicationDbContext();
        }

        public List<Detail_Commande> ListerDetails(int commandeId)
        {
            return _context.DetailCommandes
                .Where(d => d.CommandeId == commandeId)
                .Include(d => d.Produit)
                .ToList();
        }

        public void AjouterProduitCommande(int commandeId, int produitId, int quantite)
        {
            var commande = _context.Commandes.FirstOrDefault(c => c.Id == commandeId);
            if (commande == null)
                throw new Exception("Commande non trouvée");

            var produit = _context.Produits.FirstOrDefault(p => p.Id == produitId);
            if (produit == null)
                throw new Exception("Produit non trouvé");

            if (produit.QuantiteEnStock < quantite)
                throw new Exception("Stock insuffisant");

            produit.QuantiteEnStock -= quantite;

            var detailCommande = new Detail_Commande
            {
                CommandeId = commandeId,
                ProduitId = produitId,
                Quantite = quantite
            };

            _context.DetailCommandes.Add(detailCommande);
            _context.SaveChanges();
        }

        public void SupprimerProduitCommande(int commandeId, int produitId)
        {
            var detailCommande = _context.DetailCommandes
                .FirstOrDefault(d => d.CommandeId == commandeId && d.ProduitId == produitId);
            if (detailCommande == null)
                throw new Exception("Produit non trouvé dans la commande");

            var produit = _context.Produits.FirstOrDefault(p => p.Id == produitId);
            if (produit == null)
                throw new Exception("Produit non trouvé");

            produit.QuantiteEnStock += detailCommande.Quantite;

            _context.DetailCommandes.Remove(detailCommande);
            _context.SaveChanges();
        }
    }
}
