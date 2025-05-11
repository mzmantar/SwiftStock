using System;
using System.Collections.Generic;
using System.Linq;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class AlerteStockController
    {
        private readonly ApplicationDbContext _context;
        private const int SeuilStockFaible = 5;

        public AlerteStockController()
        {
            _context = new ApplicationDbContext();
        }

        public List<Produit> ObtenirProduitsAvecStockFaible()
        {
            return _context.Produits
                .Where(p => p.QuantiteEnStock <= SeuilStockFaible)
                .ToList();
        }

    
        public void AfficherAlertesStock()
        {
            var produitsFaibles = ObtenirProduitsAvecStockFaible();

            if (!produitsFaibles.Any())
            {
                Console.WriteLine("Aucun produit avec un stock faible.");
                return;
            }

            Console.WriteLine("Produits avec un stock faible :");
            foreach (var produit in produitsFaibles)
            {
                Console.WriteLine($"- {produit.Nom} (Stock restant : {produit.QuantiteEnStock})");
            }
        }
    }
}
