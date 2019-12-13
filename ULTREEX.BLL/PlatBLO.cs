using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class PlatBLO
    {
        RepositoryFileDAL<Plat> platDAO;

        public PlatBLO()
        {
            platDAO = new RepositoryFileDAL<Plat>();
        }

        public void Add(Plat plat)
        {
            platDAO.Add(plat);
        }

        public void Edit(Plat oldPlat, Plat newPlat)
        {
            platDAO.Edit(oldPlat, newPlat);
        }

        public int Count()
        {
            return platDAO.Count();
        }

        public Plat Get(Plat plat)
        {
            return platDAO.Get(plat);
        }

        public IEnumerable<Plat> GetAll()
        {
            return platDAO.GetAll();
        }

        public void Set(Plat plat)
        {
            platDAO.Set(plat);
        }

        public IEnumerable<Plat> Find(Func<Plat, bool> predicate)
        {
            return platDAO.Find(predicate);
        }

        public void Remove(Plat plat)
        {
            platDAO.Remove(plat);
        }

        public void RemoveAt(int index)
        {
            platDAO.RemoveAt(index);
        }

        public int IndexOf(Plat plat)
        {
            return platDAO.IndexOf(plat);
        }
    }
}
