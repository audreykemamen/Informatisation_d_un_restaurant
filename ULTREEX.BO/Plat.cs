using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class Plat
    {
        private static int count = 0;

        /// <summary>
        /// identifiant de la ligne du plat, où une ligne représente un aliment commandé (boisson, complémént, sauce, glace, ...)
        /// </summary>
        public int IdPlat{ get; set; }

        /// <summary>
        /// nom de l'article commandé
        /// </summary>
        public string LineName { get; set; } 

        /// <summary>
        /// quantité en stock de l'article. Lorsqu'elle est nulle, elle disparaît du menu
        /// </summary>
        public static int StockLine = 5;

        /// <summary>
        /// quantité de l'article commandé
        /// </summary>
        public int QuantityLine { get; set; }

        /// <summary>
        /// prix unitaire de l'article
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// unite de mesure 
        /// </summary>
        public string Unite { get; set; }


        //Constructeur pour ajouter un plat dans le menu
        public Plat(string lineName, double price, string unite)
        {
            IdPlat = ++count;
            LineName = lineName;
            Price = price;
            Unite = unite;
            StockLine--;
        }

        //Constructeur pour créer un plat de commande: 
        public Plat(string lineName, int quantityLine, double price)
        {
            LineName = lineName;
            QuantityLine = quantityLine;
            Price = price;
        }

        public override string ToString()
        {
            return LineName + " - " + Price;
        }

        public override bool Equals(object obj)
        {
            return obj is Plat plat &&
                   IdPlat == plat.IdPlat;
        }

        public override int GetHashCode()
        {
            return IdPlat.GetHashCode();
        }
    }
}
