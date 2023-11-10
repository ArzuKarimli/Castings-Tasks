using Castings_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings_practice
{
    internal class Generics<T>where T : BaseEntity
    {
        private T[] _list;
        public Generics()
        {
            _list = new T[0];
        }

        public T[] Add(T item)
        {
            Array.Resize(ref _list, _list.Length+1);
            _list[_list.Length-1] = item;
            return _list;
        }
        public T[] GetAll()
        {
            return _list;
        }

        public T GetById(int id)=> _list.FirstOrDefault(x => x.Id == id);

        public T[] Delete(int id)
        {
            return _list = _list.Where(x => x.Id != id).ToArray();
        }
    }
}
