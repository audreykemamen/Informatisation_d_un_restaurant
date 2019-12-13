using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class Menu
    {
        private int count = 0;

        public int IdMenu { get; set; }

        public string NomMenu { get; set; }

        public string PhotoMenu { get; set; }

        public List<Plat> Plats { get; set; }

        public Menu(string nomMenu, string photoMenu, List<Plat> plats)
        {
            IdMenu = ++count;
            NomMenu = nomMenu;
            PhotoMenu = photoMenu;
            Plats = plats;
        }

        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   IdMenu == menu.IdMenu;
        }

        public override int GetHashCode()
        {
            return IdMenu.GetHashCode();
        }

        public override string ToString()
        {
            return NomMenu;
        }
    }
}
