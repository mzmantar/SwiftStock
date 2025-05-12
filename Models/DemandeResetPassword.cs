using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftStock.Models
{
    public class DemandeResetPassword
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string Etat { get; set; }

        public DateTime DateDemande { get; set; }
    }
}
