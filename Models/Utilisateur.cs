using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SwiftStock.Models
{
    public enum RoleUtilisateur
    {
        SuperAdmin,
        Admin,
        Client
    }
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string NomUtilisateur { get; set; }

        [Required]
        [MaxLength(100)]
        public required string MotDePasse { get; set; }

        [Required]
        [MaxLength(20)]
        public RoleUtilisateur TypeUtilisateur { get; set; }
    }
}
