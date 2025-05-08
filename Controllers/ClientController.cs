using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftStock.Data;
using SwiftStock.Models;

namespace SwiftStock.Controllers
{
    public class ClientController
    {
        private readonly ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }

        public List<Client> ListerClients()
        {
            return _context.Clients.ToList();
        }

        public void AjouterClient(string nom, string email, string adresse, string telephone)
        {
          
            var clientExistant = _context.Clients.FirstOrDefault(c => c.Email == email);
            if (clientExistant != null)
                throw new Exception("Un client avec cet email existe déjà");

            var client = new Client
            {
                Nom = nom,
                Email = email,
                Adresse = adresse,
                Telephone = telephone
            };

            _context.Clients.Add(client);
            _context.SaveChanges();
        }

  
        public void ModifierClient(int id, string nom, string email, string adresse, string telephone)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
                throw new Exception("Client non trouvé");

            client.Nom = nom;
            client.Email = email;
            client.Adresse = adresse;
            client.Telephone = telephone;

            _context.SaveChanges();
        }

        public void SupprimerClient(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
                throw new Exception("Client non trouvé");

            _context.Clients.Remove(client);
            _context.SaveChanges();
        }

        public Client ConsulterClient(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
                throw new Exception("Client non trouvé");

            return client;
        }
    }
}
