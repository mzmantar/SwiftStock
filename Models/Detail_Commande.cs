using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftStock.Models
{
    public class Detail_Commande
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("Produit")]
        public int ProduitId { get; set; }

        public Produit Produit { get; set; }

        [Required]
        [ForeignKey("Commande")]
        public int CommandeId { get; set; }

        public Commande Commande { get; set; } 

        [Required]
        public int Quantite { get; set; }
    }
}
