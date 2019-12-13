using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    public enum Villes
    {
        Douala,
        Yaoundé,
        Bafoussam

    }

    public enum Quartiers
    {
        Bonaoussadi,
        Kotto,
        Bastos,
        Akwa,
        Jouvence
    }

    public class Localisation
    {
        private int count = 0;

        public int IdLocalisation { get; set; }

        public Villes Ville { get; set; }

        public Quartiers Quartier { get; set; }

        public Localisation(Villes ville, Quartiers quartier)
        {
            IdLocalisation = ++count;
            Ville = ville;
            Quartier = quartier;
        }

        public override bool Equals(object obj)
        {
            return obj is Localisation localisation &&
                   IdLocalisation == localisation.IdLocalisation;
        }

        public override int GetHashCode()
        {
            return IdLocalisation.GetHashCode();
        }

        public override string ToString()
        {
            return Ville + " - " + Quartier;
        }
    }
}
