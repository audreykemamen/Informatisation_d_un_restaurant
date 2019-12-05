using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.BO
{
    [Serializable]
    public class User
    {
        private static int count = 0;

        public int IdUser { get; set; }

        public string Name { get; set; } //nom propre de l'utilisateur

        public string UserName { get; set; } //nom d'utiliateur 

        public string Password { get; set; } //mot de passe de l'utilisateur

        public string Image { get; set; }

        public User(string name, string userName, string password)
        {
            IdUser = ++count;
            Name = name;
            UserName = userName;
            Password = password;
        }

        public User(string name, string userName, string password, string image) : this(name, userName, password)
        {
            Image = image;
        }

        public override string ToString()
        {
            return UserName;
        }

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   UserName == user.UserName;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }
    }
}
