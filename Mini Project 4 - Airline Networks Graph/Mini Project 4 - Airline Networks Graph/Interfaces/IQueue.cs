using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph.Interfaces
{
    public interface Queue<T> : IContainer<T>
    {
        void enqueue(T item);
        public T dequeue();
        public T peek();
    }
}
