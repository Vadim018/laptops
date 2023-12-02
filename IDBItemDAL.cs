using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    interface IDBItemDAL<T> where T : IID
    {
        List<T> Items { get; set; }
        void Add(T item);
        T GetById(int id);
        bool Delete(T item);
        bool Update(T oldItem, T newItem);
    }
}