using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class CommandeController
    {
        private readonly ApplicationDbContext _context;

        public CommandeController()
        {
            _context = new ApplicationDbContext();
        }
        public void CreerCommande(int clientId, List<(int produitId, int quantite)> produits)
        {
            var commande = new Commande
            {
                ClientId = clientId
            };

            _context.Commandes.Add(commande);
            _context.SaveChanges(); 

            foreach (var item in produits)
            {
                var produit = _context.Produits.FirstOrDefault(p => p.Id == item.produitId);
                if (produit == null) throw new Exception("Produit non trouvé");

                if (produit.QuantiteEnStock < item.quantite)
                    throw new Exception($"Stock insuffisant pour le produit {produit.Nom}");

                produit.QuantiteEnStock -= item.quantite;

                var detail = new Detail_Commande
                {
                    CommandeId = commande.Id,
                    ProduitId = item.produitId,
                    Quantite = item.quantite
                };
                _context.DetailCommandes.Add(detail);
            }

            _context.SaveChanges();
        }
        public List<Commande> ListerCommandes()
        {
            return _context.Commandes.ToList();
        }

        public List<Detail_Commande> ListerDetailsCommande(int commandeId)
        {
            return _context.DetailCommandes
                .Where(d => d.CommandeId == commandeId)
                .ToList();
        }
    }
}
