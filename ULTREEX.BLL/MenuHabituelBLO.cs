using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class MenuHabituelBLO
    {
        RepositoryFileDAL<MenuHabituel> menuHabituelDAO;

        public MenuHabituelBLO()
        {
            menuHabituelDAO = new RepositoryFileDAL<MenuHabituel>();
        }

        public void Add(MenuHabituel menuHabituel)
        {
            menuHabituelDAO.Add(menuHabituel);
        }

        public void Edit(MenuHabituel oldMenuHabituel, MenuHabituel newMenuHabituel)
        {
            menuHabituelDAO.Edit(oldMenuHabituel, newMenuHabituel);
        }

        public int Count()
        {
            return menuHabituelDAO.Count();
        }

        public MenuHabituel Get(MenuHabituel menuHabituel)
        {
            return menuHabituelDAO.Get(menuHabituel);
        }

        public IEnumerable<MenuHabituel> GetAll()
        {
            return menuHabituelDAO.GetAll();
        }

        public void Set(MenuHabituel menuHabituel)
        {
            menuHabituelDAO.Set(menuHabituel);
        }

        public IEnumerable<MenuHabituel> Find(Func<MenuHabituel, bool> predicate)
        {
            return menuHabituelDAO.Find(predicate);
        }

        public void Remove(MenuHabituel menuHabituel)
        {
            menuHabituelDAO.Remove(menuHabituel);
        }

        public void RemoveAt(int index)
        {
            menuHabituelDAO.RemoveAt(index);
        }

        public int IndexOf(MenuHabituel menuHabituel)
        {
            return menuHabituelDAO.IndexOf(menuHabituel);
        }
    }
}
