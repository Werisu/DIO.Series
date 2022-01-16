using DIO.Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> serieList = new List<Serie>();
        public void Delete(int id)
        {
            serieList[id].Delete();
        }

        public Serie GetById(int id)
        {
            return serieList[id];
        }

        public void Insert(Serie entidade)
        {
            serieList.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return serieList;
        }

        public int NextId()
        {
            return serieList.Count;
        }

        public void Update(int id, Serie entidade)
        {
            serieList[id] = entidade;
        }
    }
}
