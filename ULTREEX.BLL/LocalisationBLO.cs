using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    class LocalisationBLO
    {
        RepositoryFileDAL<Localisation> localisationDAO;

        public LocalisationBLO()
        {
            localisationDAO = new RepositoryFileDAL<Localisation>();
        }

        public void Add(Localisation localisation)
        {
            localisationDAO.Add(localisation);
        }

        public void Edit(Localisation oldLocalisation, Localisation newLocalisation)
        {
            localisationDAO.Edit(oldLocalisation, newLocalisation);
        }

        public int Count()
        {
            return localisationDAO.Count();
        }

        public Localisation Get(Localisation localisation)
        {
            return localisationDAO.Get(localisation);
        }

        public IEnumerable<Localisation> GetAll()
        {
            return localisationDAO.GetAll();
        }

        public void Set(Localisation localisation)
        {
            localisationDAO.Set(localisation);
        }

        public IEnumerable<Localisation> Find(Func<Localisation, bool> predicate)
        {
            return localisationDAO.Find(predicate);
        }

        public void Remove(Localisation localisation)
        {
            localisationDAO.Remove(localisation);
        }

        public void RemoveAt(int index)
        {
            localisationDAO.RemoveAt(index);
        }

        public int IndexOf(Localisation localisation)
        {
            return localisationDAO.IndexOf(localisation);
        }
    }
}
