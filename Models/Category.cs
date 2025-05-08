using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftStock.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public ICollection<Produit> Produits { get; set; }
    }
}
