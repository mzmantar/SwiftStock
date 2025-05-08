using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwiftStock.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public List<Commande> Commandes { get; set; }


    }


}
