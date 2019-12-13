using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;
using ULTREEX.BLL;

namespace ULTREEX.BLL
{
    public class RecapCommandeBLO
    {
        RepositoryFileDAL<RecapCommande> recapCommandeDAO = null;

        public RecapCommandeBLO()
        {
            recapCommandeDAO = new RepositoryFileDAL<RecapCommande>();
        }


        public void AjouterRecapCommande(RecapCommande recapCommande)
        {
            recapCommandeDAO.Add(recapCommande);
        }

        public void SupprimerRecapCommande(RecapCommande recapCommande)
        {
            recapCommandeDAO.Remove(recapCommande);
        }

        public void AnnulerRecapCommande(RecapCommande recapCommande, TimeSpan timer)
        {
            if (timer.Duration().Seconds >= 120000)
                throw new TimeoutException("RecapCommande déjà validée. Impossible d'annuler car temps d'attente écoulé!");
            else
            {
                recapCommandeDAO.Remove(recapCommande);
            }
        }

        public void ModifierRecapCommande(RecapCommande oldRecapCommande, RecapCommande newRecapCommande)
        {
            recapCommandeDAO.Edit(oldRecapCommande, newRecapCommande);
        }

        public IEnumerable<RecapCommande> Find(RecapCommande recapCommande)
        {
            return recapCommandeDAO.Find(x => true);
        }

        public RecapCommande Get(RecapCommande recapCommande)
        {
            return recapCommandeDAO.Get(recapCommande);
        }

        public void Set(RecapCommande recapCommande)
        {
            recapCommandeDAO.Set(recapCommande);
        }
    }
}
