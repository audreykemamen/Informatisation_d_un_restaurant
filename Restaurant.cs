using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    public class Restaurant
    {
        private int count = 0;
            
        public int IdRestaurant { get; set; }

        public string Nom { get; set; }

        public User Restaurateur { get; set; }

        public int Etoiles { get; set; }

        public Localisation Localisation { get; set; }

        public string Photo { get; set; }

        public List<Menu> Menus { get; set; }

        public Restaurant(string nom, User restaurateur, int etoiles, Localisation localisation, string photo, List<Menu> menus)
        {
            IdRestaurant = ++count;
            Nom = nom;
            Restaurateur = restaurateur;
            Etoiles = etoiles;
            Localisation = localisation;
            Photo = photo;
            Menus = menus;
        }

        public Restaurant(string nom, User restaurateur, int etoiles, Localisation localisation, string photo)
        {
            IdRestaurant = ++count;
            Nom = nom;
            Restaurateur = restaurateur;
            Etoiles = etoiles;
            Localisation = localisation;
            Photo = photo;
        }

        public override bool Equals(object obj)
        {
            return obj is Restaurant restaurant &&
                   IdRestaurant == restaurant.IdRestaurant;
        }

        public override int GetHashCode()
        {
            return IdRestaurant.GetHashCode();
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
