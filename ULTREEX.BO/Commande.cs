using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class Commande
    {
        private static int count = 0;

        public int IdCommand { get; set; }

        public List<Plat> Plats { get; set; }

        public Plat Plat { get; set; }

        public Client ClientCommande { get; set; }

        public int Quantite { get; set; }

        public string NumSiege { get; set; }

        public Commande(List<Plat> plats, Plat plat, Client clientCommande, int quantite, string numSiege)
        {
            IdCommand = ++count;
            Plats = plats;
            Plat = plat;
            ClientCommande = clientCommande;
            Quantite = quantite;
            NumSiege = numSiege;
        }

        public override string ToString()
        {
            return IdCommand.ToString() + " - " + NumSiege.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Commande commande &&
                   IdCommand == commande.IdCommand;
        }

        public override int GetHashCode()
        {
            return IdCommand.GetHashCode();
        }
    }
}
