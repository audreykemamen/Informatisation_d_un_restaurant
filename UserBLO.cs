using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;
using ULTREEX.DAL;

namespace ULTREEX.BLL
{
    public class UserBLO
    {
        private RepositoryFileDAL<User> userDAO;

        User user;

        public UserBLO()
        {
            userDAO = new RepositoryFileDAL<User>();
            //var count = userDAO.Find(user => true).Count();
            //if (count == 0)
            //{
            //    //création d'un user par défaut s'il en existe pas
            //    userDAO.Add(user);
            //    Console.WriteLine("Ok");
            //}
        }

        public User Login(string username, string password)
        {
            var users = userDAO.Find(x => x.UserName.ToLower().Equals(username.ToLower()) && x.Password.Equals(password));
            for(int i = 0; i < userDAO.Count(); i++)
            {
                if(userDAO.GetAt(i).UserName.Equals(username.ToLower()) && userDAO.GetAt(i).Password.Equals(password))
                {
                    user = userDAO.GetAt(i);
                }
                else
                {
                    user = null;
                }
            }

            return user;
        }

        public void Edit(User oldUser, User newUser)
        {
            int oldIndex = userDAO.IndexOf(oldUser);
            int newIndex = userDAO.IndexOf(newUser);

            userDAO.Edit(oldUser, newUser);
        }

        public void Add(User user)
        {
            userDAO.Add(user);
        }

        public int Count => userDAO.Count();

        public void Insert(int index, User user)
        {
            userDAO.Insert(index, user);
        }

        public void CopyToList(List<User> Elements)
        {
            userDAO.CopyToList(Elements);
        }

        public User GetAt(int index)
        {
            return userDAO.GetAt(index);
        }

        public bool Contains(User user)
        {
            return userDAO.Contains(user) ? true : false;
        }
    }
}
