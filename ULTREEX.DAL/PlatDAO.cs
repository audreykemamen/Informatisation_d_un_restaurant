using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;

namespace ULTREEX.DAL
{
    public class PlatDAO
    {
        private static List<Plat> Plats;
        private BinaryFormatter binaryFormatter;
        private FileInfo file;
        private const string FILEPATH = "data/plat.data";

        public PlatDAO()
        {
            binaryFormatter = new BinaryFormatter();
            file = new FileInfo(FILEPATH);
            if (!file.Directory.Exists)
                file.Directory.Create();

            if (!file.Exists)
                file.Create();

            file.Refresh();

            if (file.Length > 0)
            {
                using (FileStream fs = file.OpenRead())
                {
                    Plats = (List<Plat>)binaryFormatter.Deserialize(fs);
                }

            }
            else
            {
                if (Plats == null)
                {
                    Plats = new List<Plat>
                    {
                        new Plat("koki", 500, "boule"),
                        new Plat("nkondrès", 1000, "Assiette"),
                        new Plat("pilé de plantains", 300, "bol"),
                        new Plat("Jus d'ananas", 500, "Litre"),
                        new Plat("Eau minérale", 350, "Litre")
                    };
                }

                using (FileStream fs = file.OpenWrite())
                {
                    binaryFormatter.Serialize(fs, Plats);
                }
            }

        }

        public void Add(Plat plat)
        {
            if (plat == null)
                throw new ArgumentNullException("plat");
            if (Plats.Contains(plat))
                throw new DuplicateWaitObjectException();

            Plats.Add(plat);

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Plats);
            }
        }

        public IEnumerable<Plat> Find(Func<Plat, bool> predicate)
        {
            return Plats.Where(predicate).ToArray();
        }

        public Plat Get(Plat plat)
        {
            if (plat == null)
                throw new ArgumentNullException("plat");
            int index = Plats.IndexOf(plat);
            if (index >= 0)
                return Plats[index];

            return null;
        }

        public void Remove(Plat plat)
        {
            if (plat == null)
                throw new ArgumentNullException("plat");
            if (Get(plat) != null)
            {
                Plats.Remove(plat);

                using (FileStream fs = file.OpenWrite())
                {
                    binaryFormatter.Serialize(fs, Plats);
                }
            }

        }

        public void Set(Plat plat)
        {
            if (plat == null)
                throw new ArgumentNullException("plat");
            int index = Plats.IndexOf(plat);
            if (index >= 0)
                Plats[index] = plat;

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Plats);
            }

        }

    }
}
