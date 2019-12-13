using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class MenuHabituel 
    {
        private int count = 0;

        public int IdMenuHabituel { get; set; }

        public string IntituleMenu { get; set; }

        public string PhotoMenuHabituel { get; set; }

        public List<Plat> PlatsHabituels { get; set; }

        public MenuHabituel(string intituleMenu, string photoMenuHabituel, List<Plat> platsHabituels)
        {
            IdMenuHabituel = ++count;
            IntituleMenu = intituleMenu;
            PhotoMenuHabituel = photoMenuHabituel;
            PlatsHabituels = platsHabituels;
        }

        public override bool Equals(object obj)
        {
            return obj is MenuHabituel habituel &&
                   IdMenuHabituel == habituel.IdMenuHabituel;
        }

        public override int GetHashCode()
        {
            return IdMenuHabituel.GetHashCode();
        }


    }
}
