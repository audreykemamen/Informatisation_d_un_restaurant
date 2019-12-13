using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class Livraison
    {
        private int count = 0;

        public int IdLivraison { get; set; }

        public DateTime DateLivraison { get; set; }

        public Localisation LieuLivraison { get; set; }

        public Client ClientLivraison { get; set; }

        public List<Plat> Plats { get; set; }

        public Plat Plat { get; set; }

        public int Quantite { get; set; }

        public Livraison(DateTime dateLivraison, Localisation lieuLivraison, Client clientLivraison, List<Plat> plats, Plat plat, int quantite)
        {
            IdLivraison = ++count;
            DateLivraison = dateLivraison;
            LieuLivraison = lieuLivraison;
            ClientLivraison = clientLivraison;
            Plats = plats;
            Plat = plat;
            Quantite = quantite;
        }

        public override bool Equals(object obj)
        {
            return obj is Livraison livraison &&
                   IdLivraison == livraison.IdLivraison;
        }

        public override int GetHashCode()
        {
            return IdLivraison.GetHashCode();
        }

        public override string ToString()
        {
            return IdLivraison.ToString() + LieuLivraison;
        }
    }
}
