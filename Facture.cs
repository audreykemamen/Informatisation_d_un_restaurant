using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class Facture
    {
        private static int Count = 0;

        public int IdBill { get; set; }

        public double TotalAmount { get; set; }

        public string RestaurantName { get; set; }

        public Commande Commande { get; set; }

        public User User { get; set; }

        public Facture(int idBill, double totalAmount, string restaurantName, User user, Commande commande)
        {
            TotalAmount = totalAmount;
            RestaurantName = restaurantName;
            User = user;
            Commande = commande;
            IdBill = Count++;
        }

        public override bool Equals(object obj)
        {
            var facture = obj as Facture;
            return facture != null &&
                   IdBill == facture.IdBill;
        }

        public override int GetHashCode()
        {
            return IdBill.GetHashCode();
        }
    }
}
