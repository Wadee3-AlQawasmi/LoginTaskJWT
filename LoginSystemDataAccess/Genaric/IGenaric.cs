using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystemDataAccess.Genaric
{
   public interface IGenaric<T> where T : class
    {
        void Insert(T obj);

        List<T> Load();

        void Delete(int ID);

        T Edit(int ID);
        void Update(T obj);
    }
}
