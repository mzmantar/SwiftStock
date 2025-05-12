using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Models;
using SwiftStock.Data;


namespace SwiftStock.Controllers
{
    public class DemandeResetPasswordController
    {
        private readonly ApplicationDbContext _context;

        public DemandeResetPasswordController()
        {
            _context = new ApplicationDbContext();
        }

        public bool CreerDemande(string username)
        {
            var utilisateur = _context.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == username);
            if (utilisateur == null)
                return false;

            var demandeExistante = _context.DemandesResetPassword
                .FirstOrDefault(d => d.Username == username && d.Etat == "En attente");

            if (demandeExistante != null)
                return false;

            var nouvelleDemande = new DemandeResetPassword
            {
                Username = username,
                Etat = "En attente",
                DateDemande = DateTime.Now
            };

            _context.DemandesResetPassword.Add(nouvelleDemande);
            _context.SaveChanges();

            return true;
        }
    
        public List<DemandeResetPassword> GetDemandesEnAttente()
        {
            return _context.DemandesResetPassword
                .Where(d => d.Etat == "En attente")
                .ToList();
        }

        
        public void AccepterDemande(int demandeId)
        {
            var demande = _context.DemandesResetPassword.FirstOrDefault(d => d.Id == demandeId);
            if (demande != null)
            {
                demande.Etat = "Acceptée";
                _context.SaveChanges();
            }
        }

       
        public void RefuserDemande(int demandeId)
        {
            var demande = _context.DemandesResetPassword.FirstOrDefault(d => d.Id == demandeId);
            if (demande != null)
            {
                demande.Etat = "Refusée";
                _context.SaveChanges();
            }
        }

        
        public Utilisateur GetUtilisateurParDemande(int demandeId)
        {
            var demande = _context.DemandesResetPassword.FirstOrDefault(d => d.Id == demandeId);
            if (demande != null)
            {
                return _context.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == demande.Username);
            }

            return null;
        }
    }
}
