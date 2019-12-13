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

    public class CategorieMenu
    {
        private int count = 0;

        public int IdCategorie { get; set; }

        public Categorie IntituleCategorie { get; set; }

        public Menu Menus { get; set; }

        public CategorieMenu(Categorie intituleCategorie, Menu menus)
        {
            IdCategorie = ++count;
            IntituleCategorie = intituleCategorie;
            Menus = menus;
        }
    }
}
