using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    public enum Categorie
    {
        All,
        Pizza,
        Burger,
        Dessert,
        Boisson
    }

    public class CatégorieMenu
    {
        public int IdCategorie { get; set; }

        public Categorie IntituleCategorie { get; set; }

        public Menu Menus { get; set; }
    }
}
