using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ULTREEX.BO;

namespace ULTREEX.DAL
{
    public class RepositoryFileDAL<T> : IDAL<T>, IList<T>
    {
        /// <summary>
        /// Repositoire général qui permettra de sauvegarder et sérialiser ou désérialiser les données en fonction des types de données.
        /// La sérialisation est de type binaire
        /// </summary>
        private static List<T> Elements;
        private BinaryFormatter binaryFormatter;
        private FileInfo file;
        private string FILEPATH = "data/" + typeof(T).ToString() + ".data";

        int ICollection<T>.Count => ((IList<T>)Elements).Count;

        public bool IsReadOnly => ((IList<T>)Elements).IsReadOnly;

        public T this[int index] { get => ((IList<T>)Elements)[index]; set => ((IList<T>)Elements)[index] = value; }

        public RepositoryFileDAL()
        {
            Elements = new List<T>();
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
                    Elements = (List<T>)binaryFormatter.Deserialize(fs);
                }

            }

        }

        public int IndexOf(T t)
        {
            return Elements.IndexOf(t);
        }

        public void Add(T t)
        {
            if (t == null)
                throw new ArgumentNullException(typeof(T).ToString());
            if (Elements.Contains(t))
                throw new DuplicateWaitObjectException();
            Elements.Add(t);

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Elements);
            }
        }

        public int Count()
        {
            if(Elements == null || Elements == default)
                throw new ArgumentNullException(typeof(T).ToString());
            return Elements.Count();

        }

        public void Edit(T t1, T t2)
        {
            int oldIndex = Elements.IndexOf(t1);
            int newIndex = Elements.IndexOf(t2);

            if (t1 == null || t2 == null)
                throw new ArgumentNullException();

            if (oldIndex > -1 && (oldIndex == newIndex || newIndex == -1))
            {
                Elements[oldIndex] = t2;

                using (FileStream fs = file.OpenWrite())
                {
                    binaryFormatter.Serialize(fs, Elements);
                }
            }
            if (oldIndex == -1)
                throw new KeyNotFoundException(t1.GetType().ToString());

            if (newIndex != -1 && oldIndex != newIndex)
                throw new DuplicateWaitObjectException(t1.GetType().ToString());
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException("predicate");
            return Elements.Where(predicate).ToArray();
        }

        public T Get(T t)
        {
            if (t == null)
                throw new ArgumentNullException(typeof(T).ToString());
            int index = Elements.IndexOf(t);
            if (index >= 0)
                return Elements[index];
            return default;
        }

        public T GetAt(int index)
        {
            return Elements[index];
        }

        public void Remove(T t)
        {
            if (t == null)
                throw new ArgumentNullException(typeof(T).ToString());
            if (Get(t) != null)
                Elements.Remove(t);

            using (FileStream fs = file.OpenWrite())
            {
                binaryFormatter.Serialize(fs, Elements);
            }
        }

        public void RemoveAt(int index)
        {
            if (Elements == null || Elements == default)
                throw new ArgumentNullException(typeof(T).ToString());
            if (index < 0 || index >= Elements.Count())
                throw new ArgumentOutOfRangeException(typeof(T).ToString());
            Elements.RemoveAt(index);
        }

        public void Set(T t)
        {
            if (t == null)
                throw new ArgumentNullException(typeof(T).ToString());
            int index = Elements.IndexOf(t);
            if (index >= 0)
                Elements[index] = t;
        }

        public IEnumerable<T> GetAll()
        {
            if (Elements == null || Elements == default)
                throw new ArgumentNullException(typeof(T).ToString());
            return Elements.ToArray();
        }

        public void Insert(int index, T t)
        {
            ((IList<T>)Elements).Insert(index, t);
        }

        public void Clear()
        {
            ((IList<T>)Elements).Clear();
        }

        public bool Contains(T t)
        {
            return ((IList<T>)Elements).Contains(t);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((IList<T>)Elements).CopyTo(array, arrayIndex);
        }

        bool ICollection<T>.Remove(T t)
        {
            return ((IList<T>)Elements).Remove(t);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IList<T>)Elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<T>)Elements).GetEnumerator();
        }

        public void CopyToList(List<T> L)
        {
            Elements.AddRange(L);
        }
    }

}
