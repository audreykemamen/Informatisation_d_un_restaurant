using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class MenuDuJourBLO
    {
        RepositoryFileDAL<MenuDuJour> menuDuJourDAO;

        public MenuDuJourBLO()
        {
            menuDuJourDAO = new RepositoryFileDAL<MenuDuJour>();
        }

        public void Add(MenuDuJour menuDuJour)
        {
            menuDuJourDAO.Add(menuDuJour);
        }

        public void Edit(MenuDuJour oldMenuDuJour, MenuDuJour newMenuDuJour)
        {
            menuDuJourDAO.Edit(oldMenuDuJour, newMenuDuJour);
        }

        public int Count()
        {
            return menuDuJourDAO.Count();
        }

        public MenuDuJour Get(MenuDuJour menuDuJour)
        {
            return menuDuJourDAO.Get(menuDuJour);
        }

        public IEnumerable<MenuDuJour> GetAll()
        {
            return menuDuJourDAO.GetAll();
        }

        public void Set(MenuDuJour menuDuJour)
        {
            menuDuJourDAO.Set(menuDuJour);
        }

        public IEnumerable<MenuDuJour> Find(Func<MenuDuJour, bool> predicate)
        {
            return menuDuJourDAO.Find(predicate);
        }

        public void Remove(MenuDuJour menuDuJour)
        {
            menuDuJourDAO.Remove(menuDuJour);
        }

        public void RemoveAt(int index)
        {
            menuDuJourDAO.RemoveAt(index);
        }

        public int IndexOf(MenuDuJour menuDuJour)
        {
            return menuDuJourDAO.IndexOf(menuDuJour);
        }
    }
}
