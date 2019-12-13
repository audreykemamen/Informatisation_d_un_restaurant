using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class LivraisonBLO
    {
        RepositoryFileDAL<Livraison> livraisonDAO;

        public LivraisonBLO()
        {
            livraisonDAO = new RepositoryFileDAL<Livraison>();
        }

        public void AjouterLivraison(Livraison livraison)
        {
            livraisonDAO.Add(livraison);
        }

        public void SupprimerLivraison(Livraison livraison, TimeSpan timer)
        {
            if (timer.Duration().Seconds >= 300000)
                throw new TimeoutException("Livraison déjà validée. Impossible d'annuler car temps d'attente écoulé!");
            else
            {
                livraisonDAO.Remove(livraison);
            }
        }

        public void ModifierLivraison(Livraison oldLivraison, Livraison newLivraison)
        {
            livraisonDAO.Edit(oldLivraison, newLivraison);
        }

        public int Count()
        {
            return livraisonDAO.Count();
        }

        public Livraison Get(Livraison livraison)
        {
            return livraisonDAO.Get(livraison);
        }

        public IEnumerable<Livraison> GetAll()
        {
            return livraisonDAO.GetAll();
        }

        public void Set(Livraison livraison)
        {
            livraisonDAO.Set(livraison);
        }

        public IEnumerable<Livraison> Find(Func<Livraison, bool> predicate)
        {
            return livraisonDAO.Find(predicate);
        }

        public void RemoveAt(int index)
        {
            livraisonDAO.RemoveAt(index);
        }

        public int IndexOf(Livraison livraison)
        {
            return livraisonDAO.IndexOf(livraison);
        }
    }
}
