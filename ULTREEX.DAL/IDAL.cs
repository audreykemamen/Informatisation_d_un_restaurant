using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTREEX.DAL
{
    public interface IDAL<T>
    {
        int IndexOf(T t);

        void Add(T t);

        void Set(T t);

        T Get(T t);

        T GetAt(int index);

        IEnumerable<T> Find(Func<T, bool> predicate);

        void Edit(T t1, T t2);

        void Remove(T t);

        void RemoveAt(int index);

        int Count();

        IEnumerable<T> GetAll();
    }
}
