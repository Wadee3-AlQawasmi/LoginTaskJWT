using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystemDataAccess.Genaric
{
    public class Generic<T> : IGenaric<T> where T : class
    {
        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public T Edit(int ID)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> Load()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
