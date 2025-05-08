using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;

namespace SwiftStock.Controllers
{
    public class DashboardController
    {
        private readonly ApplicationDbContext _context;

        public DashboardController()
        {
            _context = new ApplicationDbContext();
        }

        // Récupérer les statistiques générales sur le stock
        public object GetDashboardData()
        {
            var dashboardData = new
            {
                TotalProduits = _context.Produits.Count(),
                TotalCommandes = _context.Commandes.Count(),
                TotalPaiements = _context.Paiements.Sum(p => p.Montant),
                ProduitsEnRuptureDeStock = _context.Produits.Where(p => p.QuantiteEnStock == 0).Count(),
                ProduitsLesPlusVendues = _context.DetailCommandes
                    .GroupBy(d => d.ProduitId)
                    .OrderByDescending(g => g.Sum(d => d.Quantite))
                    .Take(5)
                    .Select(g => new
                    {
                        Produit = g.FirstOrDefault().Produit.Nom,
                        QuantiteVendue = g.Sum(d => d.Quantite)
                    }).ToList()
            };

            return dashboardData;
        }

        // Récupérer les produits avec les stocks faibles
        public object GetProduitsFaiblesStock()
        {
            var produitsFaiblesStock = _context.Produits
                .Where(p => p.QuantiteEnStock < 10) // Par exemple, stock faible si moins de 10 unités
                .Select(p => new
                {
                    p.Nom,
                    p.QuantiteEnStock,
                    p.Prix
                }).ToList();

            return produitsFaiblesStock;
        }
    }
}
