using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    class DBItemDAL<T> where T : IID
    {
        int counter = 1;
        public List<T> Items { get; set; }
        public DBItemDAL()
        {
            Items = new List<T>();
        }
        public void Add(T item)
        {
            item.Id = counter++;

            Items.Add(item);
        }
        public T GetById(int id)
        {
            foreach (T item in Items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default;
        }
        public bool Delete(T item)
        {
            return Items.Remove(item);
        }
        public bool Update(T oldItem, T newItem)
        {
            newItem.Id = oldItem.Id;

            Items.Add(newItem);

            bool result = Items.Remove(oldItem);

            return result;
        }
    }
}