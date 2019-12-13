using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.DAL;
using ULTREEX.BO;

namespace ULTREEX.BLL
{
    public class RestaurantBLO
    {
        RepositoryFileDAL<Restaurant> restaurantDAO;
        
        public RestaurantBLO()
        {
            restaurantDAO = new RepositoryFileDAL<Restaurant>();
        }

        public void Add(Restaurant restaurant)
        {
            restaurantDAO.Add(restaurant);
        }

        public void Edit(Restaurant oldRestaurant, Restaurant newRestaurant)
        {
            restaurantDAO.Edit(oldRestaurant, newRestaurant);
        }

        public int Count()
        {
            return restaurantDAO.Count();
        }

        public Restaurant Get(Restaurant restaurant)
        {
            return restaurantDAO.Get(restaurant);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurantDAO.GetAll();
        }

        public void Set(Restaurant restaurant)
        {
            restaurantDAO.Set(restaurant);
        }

        public IEnumerable<Restaurant> Find(Func<Restaurant, bool> predicate)
        {
            return restaurantDAO.Find(predicate);
        }

        public void Remove(Restaurant restaurant)
        {
            restaurantDAO.Remove(restaurant);
        }

        public void RemoveAt(int index)
        {
            restaurantDAO.RemoveAt(index);
        }

        public int IndexOf(Restaurant restaurant)
        {
            return restaurantDAO.IndexOf(restaurant);
        }
    }
}
