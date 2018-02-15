using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    public class Counter<T> : iCountable
        where T : iCountable
    {
        
        // generic counter
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

        public void Add(T item)
        {
            items.Add(item);

        }

        public Counter()
        {
            items = new List<T>();
        }

        List<T> items;
    }

}
