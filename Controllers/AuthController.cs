using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class AuthController
    {
        private readonly ApplicationDbContext _context;

        public AuthController()
        {
            _context = new ApplicationDbContext();
        }
        public bool SignUp(string nomUtilisateur, string motDePasse, RoleUtilisateur role)
        {
            
            if (_context.Utilisateurs.Any(u => u.NomUtilisateur == nomUtilisateur))
                return false;

            var utilisateur = new Utilisateur
            {
                NomUtilisateur = nomUtilisateur,
                MotDePasse = motDePasse,
                TypeUtilisateur = role
            };

            _context.Utilisateurs.Add(utilisateur);
            _context.SaveChanges();
            return true;
        }

        public Utilisateur SignIn(string nomUtilisateur, string motDePasse)
        {
            return _context.Utilisateurs
                .FirstOrDefault(u => u.NomUtilisateur == nomUtilisateur && u.MotDePasse == motDePasse);
        }
    }
}
