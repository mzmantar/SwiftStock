using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftStock.Models
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Prix { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int QuantiteEnStock { get; set; }

        [MaxLength(50)]
        public string Categorie { get; set; }

        [MaxLength(200)]
        
        public string ImageUrl { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int categoryId { get; set; }
    }
}
