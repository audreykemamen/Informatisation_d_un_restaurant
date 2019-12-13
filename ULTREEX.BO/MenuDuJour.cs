using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    public enum Jours
    {
        lundi,
        mardi,
        mercredi,
        jeudi,
        vendredii,
        samedi,
        dimanche = 0
    }

    public class MenuDuJour
    {
        private int count = 0;

        public int IdMenuDuJour { get; set; }

        public Jours Jour { get; set; }

        public Menu MenuJour { get; set; }

        public Restaurant RestaurantMenu { get; set; }

        public MenuDuJour(Jours jour, Menu menuJour, Restaurant restaurantMenu)
        {
            IdMenuDuJour = ++count;
            Jour = jour;
            MenuJour = menuJour;
            RestaurantMenu = restaurantMenu;
        }

        public override bool Equals(object obj)
        {
            return obj is MenuDuJour jour &&
                   IdMenuDuJour == jour.IdMenuDuJour;
        }

        public override int GetHashCode()
        {
            return IdMenuDuJour.GetHashCode();
        }

        public override string ToString()
        {
            return MenuJour.ToString();
        }
    }
}
