using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    public class ArrayStack<T> : Stack<T>  
    {
        private readonly T[] items;
        private int top = 0;

        public ArrayStack(int capacity)
        {
            items = (T[])new T[capacity];
        }


        public void push(T item)
        {
            items[top++] = item;
        }

    
        public T pop()
        {
            return items[--top];
        }

    
        public T peek()
        {
            return items[top - 1];
        }

    
        public int getSize()
        {
            return top;
        }

        // implented from IQueue
        //public bool isEmpty()
        //{
        //    if (items.Length == 0) return true; else return false;
        //}
       


        public IEnumerable<T> iterator()
        {
            return null;
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
