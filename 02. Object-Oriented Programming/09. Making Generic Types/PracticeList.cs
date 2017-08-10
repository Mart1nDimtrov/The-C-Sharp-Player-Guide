using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Making_Generic_Types
{
    public class PracticeList<T> where T : IComparable
    {
        private T[] items;

        public PracticeList()
        {
            this.items = new T[0];
        }

        public T GetItem(int index)
        {
            return this.items[index];
        }

        public void Add(T newItem)
        {
            T[] newItems = new T[this.items.Length + 1];

            for (int index = 0; index < this.items.Length; index++)
            {
                newItems[index] = this.items[index];
            }

            newItems[newItems.Length - 1] = newItem;
            this.items = newItems;
        }
    }
}
