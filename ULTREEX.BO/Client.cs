using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{

    public enum Sexs
    {
        F,
        M,
        None
    }

    [Serializable]
    public class Client
    {
        private int count = 0;

        public int IdClient { get; set; }

        public string FullName { get; set; }

        public long PhoneNumber { get; set; }

        public Sexs Sex { get; set; }

        /*Constructeur d'un client de livraison*/
        public Client(string fullName, long phoneNumber, Sexs sex)
        {
            IdClient = ++count;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Sex = sex;
        }

        /*Construction pour un plat emporté ou une commande sur place*/
        public Client()
        {
            IdClient = ++count;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   IdClient == client.IdClient;
        }

        public override int GetHashCode()
        {
            return IdClient.GetHashCode();
        }

        public override string ToString()
        {
            return IdClient.ToString();
        }
    }
}
