using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class MenuBLO
    {
        RepositoryFileDAL<Menu> menuDAO;

        public MenuBLO()
        {
            menuDAO = new RepositoryFileDAL<Menu>();
        }

        public void Add(Menu menu)
        {
            menuDAO.Add(menu);
        }

        public void Edit(Menu oldMenu, Menu newMenu)
        {
            menuDAO.Edit(oldMenu, newMenu);
        }

        public int Count()
        {
            return menuDAO.Count();
        }

        public Menu Get(Menu menu)
        {
            return menuDAO.Get(menu);
        }

        public IEnumerable<Menu> GetAll()
        {
            return menuDAO.GetAll();
        }

        public void Set(Menu menu)
        {
            menuDAO.Set(menu);
        }

        public IEnumerable<Menu> Find(Func<Menu, bool> predicate)
        {
            return menuDAO.Find(predicate);
        }

        public void Remove(Menu menu)
        {
            menuDAO.Remove(menu);
        }

        public void RemoveAt(int index)
        {
            menuDAO.RemoveAt(index);
        }

        public int IndexOf(Menu menu)
        {
            return menuDAO.IndexOf(menu);
        }
    }
}
