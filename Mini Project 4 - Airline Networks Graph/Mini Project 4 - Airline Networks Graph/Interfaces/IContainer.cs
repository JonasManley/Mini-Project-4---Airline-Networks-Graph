using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    /**
  * Like a Collection in java.util.Collection just without mutability.
  * @param <T>
  */
    public interface IContainer<T> : IEnumerable<T>
    {
        public int getSize();
        //public bool isEmpty();
    }
}
