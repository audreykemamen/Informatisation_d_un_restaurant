using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.BLL;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{

    public class CategorieMenuBLO
    {
        RepositoryFileDAL<CategorieMenu> categorieMenuDAO = null;

        public CategorieMenuBLO()
        {
            categorieMenuDAO = new RepositoryFileDAL<CategorieMenu>();
        }


        public void AjouterCategorieMenu(CategorieMenu categorieMenu)
        {
            categorieMenuDAO.Add(categorieMenu);
        }

        public void SupprimerCategorieMenu(CategorieMenu categorieMenu)
        {
            categorieMenuDAO.Remove(categorieMenu);
        }

        public void AnnulerCategorieMenu(CategorieMenu categorieMenu, TimeSpan timer)
        {
            if (timer.Duration().Seconds >= 120000)
                throw new TimeoutException("CategorieMenu déjà validée. Impossible d'annuler car temps d'attente écoulé!");
            else
            {
                categorieMenuDAO.Remove(categorieMenu);
            }
        }

        public void ModifierCategorieMenu(CategorieMenu oldCategorieMenu, CategorieMenu newCategorieMenu)
        {
            categorieMenuDAO.Edit(oldCategorieMenu, newCategorieMenu);
        }

        public IEnumerable<CategorieMenu> Find(CategorieMenu categorieMenu)
        {
            return categorieMenuDAO.Find(x => true);
        }

        public CategorieMenu Get(CategorieMenu categorieMenu)
        {
            return categorieMenuDAO.Get(categorieMenu);
        }

        public void Set(CategorieMenu categorieMenu)
        {
            categorieMenuDAO.Set(categorieMenu);
        }
    }
}
