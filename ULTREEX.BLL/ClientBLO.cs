using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class ClientBLO
    {

        RepositoryFileDAL<Client> clientDAO;

        public ClientBLO()
        {
            clientDAO = new RepositoryFileDAL<Client>();
        }

        public void Add(Client client)
        {
            clientDAO.Add(client);
        }

        public void Edit(Client oldClient, Client newClient)
        {
            clientDAO.Edit(oldClient, newClient);
        }

        public int Count()
        {
            return clientDAO.Count();
        }

        public Client Get(Client client)
        {
            return clientDAO.Get(client);
        }

        public IEnumerable<Client> GetAll()
        {
            return clientDAO.GetAll();
        }

        public void Set(Client client)
        {
            clientDAO.Set(client);
        }

        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            return clientDAO.Find(predicate);
        }

        public void Remove(Client client)
        {
            clientDAO.Remove(client);
        }

        public void RemoveAt(int index)
        {
            clientDAO.RemoveAt(index);
        }

        public int IndexOf(Client client)
        {
            return clientDAO.IndexOf(client);
        }
    }
}
