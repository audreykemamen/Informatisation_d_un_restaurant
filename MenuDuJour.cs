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

        public int idMenuDuJour { get; set; }

        public Jours Jour { get; set; }

        public Menu MenuJour { get; set; }
    }
}
