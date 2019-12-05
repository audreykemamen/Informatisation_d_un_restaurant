using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class FactureBLO
    {
        RepositoryFileDAL<Facture> factureDAO;

        public FactureBLO()
        {
            factureDAO = new RepositoryFileDAL<Facture>();
        }

        public void Add(Facture facture)
        {
            factureDAO.Add(facture);
        }

        public void Edit(Facture oldRestaurant, Facture newRestaurant)
        {
            factureDAO.Edit(oldRestaurant, newRestaurant);
        }

        public int Count()
        {
            return factureDAO.Count();
        }

        public Facture Get(Facture facture)
        {
            return factureDAO.Get(facture);
        }

        public IEnumerable<Facture> GetAll()
        {
            return factureDAO.GetAll();
        }

        public void Set(Facture facture)
        {
            factureDAO.Set(facture);
        }

        public IEnumerable<Facture> Find(Func<Facture, bool> predicate)
        {
            return factureDAO.Find(predicate);
        }

        public void Remove(Facture facture)
        {
            factureDAO.Remove(facture);
        }

        public void RemoveAt(int index)
        {
            factureDAO.RemoveAt(index);
        }

        public int IndexOf(Facture facture)
        {
            return factureDAO.IndexOf(facture);
        }
    }
}
