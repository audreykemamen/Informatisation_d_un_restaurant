using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class RecapCommande
    {
        public int count = 0;

        public int IdRecap { get; set; }

        public string FullName { get; set; }

        public Client ClientCmd { get; set; }

        public Plat PlatCmd { get; set; }

        public int Quantite { get; set; }

        public DateTime Date { get; set; }

        public string Place { get; set; }

        /*Constructeur pour une commande complète (livraison ou commande sur place)*/
        public RecapCommande(Client clientCmd, Plat platCmd, int quantite, DateTime date, string place)
        {
            IdRecap = ++count;
            ClientCmd = clientCmd;
            PlatCmd = platCmd;
            Quantite = quantite;
            Date = date;
            Place = place;
        }

        /*Commande pour plat à emporter*/
        public RecapCommande(Client clientCmd, Plat platCmd, int quantite, DateTime date)
        {
            ClientCmd = clientCmd;
            PlatCmd = platCmd;
            Quantite = quantite;
            Date = date;
        }
    }
}
