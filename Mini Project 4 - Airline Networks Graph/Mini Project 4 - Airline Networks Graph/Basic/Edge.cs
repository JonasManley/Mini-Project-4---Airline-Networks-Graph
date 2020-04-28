using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    public class Edge
    {
        public int from;
        public int to;

        public Edge(int from, int to)
        {
            this.from = from;
            this.to = to;
        }


        public String toString()
        {
            return "" + from + " -> " + to;
        }
    }
}
