using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph.Utils
{
    public class ArrayIterator<T> : IEnumerable<T>
    {
        private readonly T[] items;
        private int index;
        private readonly int end;

        public ArrayIterator(T[] items, int start, int end)
        {
            this.items = items;
            this.index = start;
            this.end = end;
        }

        //public ArrayIterator(T[] items, int end)
        //{
        //    this(items, 0, end);
        //}


        public bool hasNext() { return index != end; }


        public T next()
        {
            T item = items[index++];
            index = index % items.Length;
            return item;
        }



        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
