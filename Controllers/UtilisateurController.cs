using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;


namespace SwiftStock.Controllers
{
    public class UtilisateurController
    {
        private readonly ApplicationDbContext _context;

        public UtilisateurController()
        {
            _context = new ApplicationDbContext();
        }

        public bool AjouterUtilisateur(Utilisateur utilisateurActuel, Utilisateur nouvelUtilisateur)
        {
            if (utilisateurActuel.TypeUtilisateur == RoleUtilisateur.SuperAdmin)
            {
                if (nouvelUtilisateur.TypeUtilisateur == RoleUtilisateur.Admin || nouvelUtilisateur.TypeUtilisateur == RoleUtilisateur.Client)
                {
                    _context.Utilisateurs.Add(nouvelUtilisateur);
                    _context.SaveChanges();
                    return true;
                }
            }
            else if (utilisateurActuel.TypeUtilisateur == RoleUtilisateur.Admin)
            {
                if (nouvelUtilisateur.TypeUtilisateur == RoleUtilisateur.Client)
                {
                    _context.Utilisateurs.Add(nouvelUtilisateur);
                    _context.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        public List<Utilisateur> ListerUtilisateurs()
        {
            return _context.Utilisateurs.ToList();
        }

        public bool SupprimerUtilisateur(int id)
        {
            var utilisateur = _context.Utilisateurs.Find(id);
            if (utilisateur != null)
            {
                _context.Utilisateurs.Remove(utilisateur);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
