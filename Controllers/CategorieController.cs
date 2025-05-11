using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class CategorieController
    {
        private readonly ApplicationDbContext _context;

        public CategorieController()
        {
            _context = new ApplicationDbContext();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public void AjouterCategorie(Category categorie)
        {
            _context.Categories.Add(categorie);
            _context.SaveChanges();
        }
        public void ModifierCategorie(Category categorie)
        {
            var categorieExistante = _context.Categories.Find(categorie.Id);
            if (categorieExistante != null)
            {
                categorieExistante.Nom = categorie.Nom;
                categorieExistante.Description = categorie.Description;
                _context.Categories.Update(categorieExistante);
                _context.SaveChanges();
            }
        }

        public void SupprimerCategorie(int id)
        {
            var categorie = _context.Categories.Find(id);
            if (categorie != null)
            {
                _context.Categories.Remove(categorie);
                _context.SaveChanges();
            }
        }

    }
}
