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

        public List<string> Plats { get; set; }

        public Plat Plat { get; set; }

        public User User { get; set; }

        public int Quantite { get; set; }

        public string NumSiege { get; set; }

        public Commande(Plat plat, int quantite, string numSiege)
        {
            Plat = plat;
            Quantite = quantite;
            NumSiege = numSiege;
            IdCommand = ++count;
        }

        public override bool Equals(object obj)
        {
            return obj is Commande commande &&
                   User == commande.User;
        }

        public override int GetHashCode()
        {
            return User.GetHashCode();
        }

        public override string ToString()
        {
            return Plat.ToString() + " - " + Quantite.ToString();
        }
    }
}
