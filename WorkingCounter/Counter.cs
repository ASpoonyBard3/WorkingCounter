using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    public class Counter<T> : ICountable
        where T : ICountable
    {
        
        //this is the count method to count an item object of undeclared type
        public int Count
        {
            get
            {
                int count = 0;
                foreach (T item in items)
                {
                    count += item.Count;
                }
                return count;
            }
        }

        //this is the add method, it adds an item to the array items, the item type is undeclared 
        public void Add(T item)
        {
            items.Add(item);

        }

        //This creates a generic type list and assigns it to "items"
        public Counter()
        {
            items = new List<T>();
        }

        //This creates the generic list items 
        List<T> items;
    }

}
