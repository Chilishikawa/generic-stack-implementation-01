using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackImplementation
{
    public class GenericStack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items == null)
            {
                throw new InvalidOperationException("The collection is not initialized.");
            }
            
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty collection.");
            }

            T poppedItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return poppedItem;
        }

        public List<T> Display()
        {
            return new List<T>(items);
        }
    }
}
