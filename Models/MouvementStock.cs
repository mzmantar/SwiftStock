using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftStock.Models
{
    public class MouvementStock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProduitId { get; set; }

        [Required]
        public TypeMouvement Type { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantite { get; set; }

        public DateTime DateMouvement { get; set; } = DateTime.Now;

        [ForeignKey("ProduitId")]
        public virtual Produit Produit { get; set; }
    }

    public enum TypeMouvement
    {
        Entree,
        Sortie
    }
}
