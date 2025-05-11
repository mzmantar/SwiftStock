using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class PaiementController
    {
        private readonly ApplicationDbContext _context;

        public PaiementController()
        {
            _context = new ApplicationDbContext();
        }

        // Lister tous les paiements
        public List<Paiement> ListerPaiements()
        {
            return _context.Paiements.ToList();
        }

        // Ajouter un paiement
        public void AjouterPaiement(int commandeId, decimal montant, DateTime datePaiement)
        {
            var paiement = new Paiement
            {
                CommandeId = commandeId,
                Montant = montant,
                DatePaiement = datePaiement
            };

            _context.Paiements.Add(paiement);
            _context.SaveChanges();
        }

        // Modifier un paiement
        public void ModifierPaiement(int id, int commandeId, decimal montant, DateTime datePaiement)
        {
            var paiement = _context.Paiements.FirstOrDefault(p => p.Id == id);
            if (paiement == null)
                throw new Exception("Paiement non trouvé");

            paiement.CommandeId = commandeId;
            paiement.Montant = montant;
            paiement.DatePaiement = datePaiement;

            _context.SaveChanges();
        }

        // Supprimer un paiement
        public void SupprimerPaiement(int id)
        {
            var paiement = _context.Paiements.FirstOrDefault(p => p.Id == id);
            if (paiement == null)
                throw new Exception("Paiement non trouvé");

            _context.Paiements.Remove(paiement);
            _context.SaveChanges();
        }

        // Consulter un paiement par son ID
        public Paiement ConsulterPaiement(int id)
        {
            var paiement = _context.Paiements.FirstOrDefault(p => p.Id == id);
            if (paiement == null)
                throw new Exception("Paiement non trouvé");

            return paiement;
        }
    }
}
