using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SwiftStock.Data;
using SwiftStock.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Formats.Asn1;

namespace SwiftStock.Controllers
{
    public class ExportImportController
    {
        private readonly ApplicationDbContext _context;

        public ExportImportController()
        {
            _context = new ApplicationDbContext();
        }

        // Exporter les produits au format CSV
        public void ExportProduitsToCsv(string filePath)
        {
            var produits = _context.Produits
                .Select(p => new
                {
                    p.Id,
                    p.Nom,
                    p.Description,
                    p.Prix,
                    p.QuantiteEnStock,
                    p.Categorie
                }).ToList();

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(produits); // Écriture des produits dans le fichier CSV
            }

            Console.WriteLine("Exportation des produits vers CSV réussie.");
        }

        // Exporter les catégories au format CSV
        public void ExportCategoriesToCsv(string filePath)
        {
            var categories = _context.Categories
                .Select(c => new
                {
                    c.Id,
                    c.Nom,
                    c.Description
                }).ToList();

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(categories); // Écriture des catégories dans le fichier CSV
            }

            Console.WriteLine("Exportation des catégories vers CSV réussie.");
        }

        // Importer des produits à partir d'un fichier CSV
        public void ImportProduitsFromCsv(string filePath)
        {
            var produitsImportes = new List<Produit>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<ProduitCsvModel>().ToList();

                foreach (var record in records)
                {
                    var produit = new Produit
                    {
                        Nom = record.Nom,
                        Description = record.Description,
                        Prix = record.Prix,
                        QuantiteEnStock = record.QuantiteEnStock,
                        Categorie = record.Categorie
                    };

                    produitsImportes.Add(produit);
                }
            }

            _context.Produits.AddRange(produitsImportes);
            _context.SaveChanges();

            Console.WriteLine("Importation des produits depuis CSV réussie.");
        }

        // Importer des catégories à partir d'un fichier CSV
        public void ImportCategoriesFromCsv(string filePath)
        {
            var categoriesImportees = new List<Category>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<CategoryCsvModel>().ToList();

                foreach (var record in records)
                {
                    var category = new Category
                    {
                        Nom = record.Nom,
                        Description = record.Description
                    };

                    categoriesImportees.Add(category);
                }
            }

            _context.Categories.AddRange(categoriesImportees);
            _context.SaveChanges();

            Console.WriteLine("Importation des catégories depuis CSV réussie.");
        }
    }

    // Modèle pour l'importation des produits depuis CSV
    public class ProduitCsvModel
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int QuantiteEnStock { get; set; }
        public string Categorie { get; set; }
    }

    // Modèle pour l'importation des catégories depuis CSV
    public class CategoryCsvModel
    {
        public string Nom { get; set; }
        public string Description { get; set; }
    }
}
