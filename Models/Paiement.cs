using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftStock.Models
{
    public class Paiement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Commande")]
        public int CommandeId { get; set; }

        public Commande Commande { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Montant { get; set; }

        [Required]
        public DateTime DatePaiement { get; set; }

        [Required]
        [MaxLength(50)]
        public string MethodePaiement { get; set; }

        [Required]
        public bool EstValide { get; set; }
    }
}
