using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    internal interface IRepository<T>
    {
        List<T> Lista();
        T GetById(int id);
        public void Insert(T entidade);
        public void Delete(int id);
        public void Update(int id, T entidade);
        public int NextId();
    }
}
