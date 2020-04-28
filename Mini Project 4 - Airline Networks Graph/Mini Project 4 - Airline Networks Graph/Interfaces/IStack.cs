using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    public interface Stack<T> : IContainer<T> {
        void push(T item);
        T pop();
        T peek();
    }
}
