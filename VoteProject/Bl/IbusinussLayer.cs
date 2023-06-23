using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    internal interface IbusinussLayer<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public void Add(T table);
        public void Delete(int id);
    }
}
