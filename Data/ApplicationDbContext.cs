using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SwiftStock.Models;

namespace SwiftStock.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<MouvementStock> MouvementsStock { get; set; }
        public DbSet<Detail_Commande> DetailCommandes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<DemandeResetPassword> DemandesResetPassword { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=swiftstockdb;user=root;password=;",
                new MySqlServerVersion(new Version(8, 0, 3))
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Utilisateur>().HasData(
                new Utilisateur
                {
                    Id = 1,
                    NomUtilisateur = "superadmin",
                    MotDePasse = "admin123",
                    TypeUtilisateur = RoleUtilisateur.SuperAdmin
                }
            );
        }
    }
}
