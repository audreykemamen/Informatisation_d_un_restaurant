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
    public class CommandeDAO 
    {
        private BinaryFormatter binaryFormatter;
        private FileInfo file;
        private string FILEPATH = "data/" + typeof(Commande).ToString() + ".data";
        private static List<Commande> Commandes = null;
       // private RepositoryFileDAL<Commande> reposCommande = new RepositoryFileDAL<Commande>();

        public CommandeDAO()
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
                    Commandes = (List<Commande>)binaryFormatter.Deserialize(fs);
                }

            }

        }

        public void Add(Commande commande)
        {
            if (commande == null)
                throw new ArgumentNullException("commande");
            if (Commandes.Contains(commande))
                throw new DuplicateWaitObjectException();

            Commandes.Add(commande);
            //reposCommande.Add(commande);

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Commandes);
            }

            //Facture facture = new Facture(commande);
        }

        public void Edit(Commande oldCommande, Commande newCommande)
        {
            int oldIndex = Commandes.IndexOf(oldCommande);
            int newIndex = Commandes.IndexOf(newCommande);

            if (oldCommande == null || newCommande == null)
                throw new ArgumentNullException();

            if (oldIndex > -1 && (oldIndex == newIndex || newIndex == -1))
            {
                Commandes[oldIndex] = newCommande;

                using (FileStream fs = file.OpenWrite())
                {
                    binaryFormatter.Serialize(fs, Commandes);
                }
            }
            if (oldIndex == -1)
                throw new KeyNotFoundException(oldCommande.Plat.LineName);

            if (newIndex != -1 && oldIndex != newIndex)
                throw new DuplicateWaitObjectException(newCommande.Plat.LineName);
        }

        public IEnumerable<Commande> Find(Func<Commande, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException("predicate");
            return Commandes.Where(predicate).ToArray();
        }

        //public Commande Get(Commande commande)
        //{
        //    if (commande == null)
        //        throw new ArgumentNullException("commande");
        //    int index = Commandes.IndexOf(commande);
        //    if (index >= 0)
        //        return Commandes[index];

        //    return null;
        //}

        public void Remove(Commande commande)
        {
            if (commande == null)
                throw new ArgumentNullException("commande");
            if (Get(commande) != null)
                Commandes.Remove(commande);

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Commandes);
            }
        }

        //public void Set(Commande commande)
        //{
        //    if (commande == null)
        //        throw new ArgumentNullException("commande");
        //    int index = Commandes.IndexOf(commande);
        //    if (index >= 0)
        //        Commandes[index] = commande;
        //}

        public int Count => Commandes.Count();
    }
}
