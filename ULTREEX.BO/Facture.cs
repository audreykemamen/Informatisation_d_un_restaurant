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

        public User Restaurateur { get; set; }

        public Client ClientInfo { get; set; }

        public Facture(int idBill, double totalAmount, string restaurantName, User restaurateur, Commande commande, Client clientInfo)
        {
            TotalAmount = totalAmount;
            RestaurantName = restaurantName;
            Restaurateur = restaurateur;
            Commande = commande;
            ClientInfo = clientInfo;
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

        public override string ToString()
        {
            return IdBill.ToString() + ClientInfo + TotalAmount.ToString();
        }
    }
}
