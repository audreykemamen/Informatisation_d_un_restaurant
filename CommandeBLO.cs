using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class CommandeBLO
    {
        RepositoryFileDAL<Commande> commandeDAO = null;

        public CommandeBLO()
        {
            commandeDAO = new RepositoryFileDAL<Commande>();
        }


        public void AjouterCommande(Commande commande)
        {
            commandeDAO.Add(commande);
        }

        public void SupprimerCommande(Commande commande)
        {
            commandeDAO.Remove(commande);
        }

        public void AnnulerCommande(Commande commande, TimeSpan timer)
        {
            if (timer.Duration().Seconds >= 120000)
                throw new TimeoutException("Commande déjà validée. Impossible d'annuler car temps d'attente écoulé!");
            else
            {
                commandeDAO.Remove(commande);
            }
        }

        public void ModifierCommande(Commande oldCommande, Commande newCommande)
        {
            commandeDAO.Edit(oldCommande, newCommande);
        }

        public IEnumerable<Commande> Find(Commande commande)
        {
            return commandeDAO.Find(x => true);
        }

        public Commande Get(Commande commande)
        {
            return commandeDAO.Get(commande);
        }

        public void Set(Commande commande)
        {
            commandeDAO.Set(commande);
        }

    }
}
