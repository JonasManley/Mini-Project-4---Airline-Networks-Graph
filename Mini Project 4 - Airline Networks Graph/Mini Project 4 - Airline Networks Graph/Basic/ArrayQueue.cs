using Mini_Project_4___Airline_Networks_Graph.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph.Basic
{
    public class ArrayQueue<T> : Queue<T>
    {
        private readonly T[] items;
        private int start = 0;
        private int end = 0;

        public ArrayQueue(int capacity)
        {
            items = (T[])new T[capacity];
        }


        public int getSize() { return end - start; }


        public void enqueue(T item)
        {
            items[end++] = item;
            end = end % items.Length;
        }


        public T dequeue()
        {
            T item = items[start++];
            start = start % items.Length;
            return item;
        }


        public T peek() { return items[start]; }



        public IEnumerable<T> iterator()
        {
            return new ArrayIterator<T>(items, start, end);
        }

        // implented from IQueue
        //public bool isEmpty()
        //{
        //    if (items.Length == 0) return true; else return false;
        //}

    }
}
