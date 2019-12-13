using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;

namespace ULTREEX.DAL
{
    public class UserDAO
    {
        private static List<User> Users = null;
        private BinaryFormatter binaryFormatter;
        private FileInfo file;
        private const string FILEPATH = "data/utilisateur.data";

        public UserDAO()
        {
            binaryFormatter = new BinaryFormatter();
            file = new FileInfo(FILEPATH);
            if (!file.Directory.Exists)
                file.Directory.Create();

            if (!file.Exists)
                file.Create();

            file.Refresh();

            if (file.Length > 0)
            {
                using (FileStream fs = file.OpenRead())
                {
                    Users = (List<User>)binaryFormatter.Deserialize(fs);
                }

            }
            else
            {
                if (Users == null)
                {
                    Users = new List<User>
                    {
                        new User("admin", "admin")
                    };
                }

                using (FileStream fs = file.OpenWrite())
                {
                    binaryFormatter.Serialize(fs, Users);
                }
            }

        }

        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");
            if (Users.Contains(user))
                throw new DuplicateWaitObjectException();

            Users.Add(user);

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Users);
            }
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return Users.Where(predicate).ToArray();
        }

        public User Get(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");
            int index = Users.IndexOf(user);
            if (index >= 0)
                return Users[index];

            return null;
        }

        public void Remove(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");
            if (Get(user) != null)
            {
                Users.Remove(user);

                using (FileStream fs = file.OpenWrite())
                {
                    binaryFormatter.Serialize(fs, Users);
                }
            }

        }

        public void Set(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");
            int index = Users.IndexOf(user);
            if (index >= 0)
                Users[index] = user;

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Users);
            }

        }

    }
}
