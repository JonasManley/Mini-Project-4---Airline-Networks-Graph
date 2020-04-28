using java.lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    public interface IGraph
    {
        int getV(); // get number of vertices V
        int getE(); // get number of edges E
        void addEdge(int v, int w); // add an edge from vertice v to vertice w
        public void AddUndirectedEdge(int v, int w);
        IEnumerable<int> adjacents(int v); // list all adjacent vertices to vertice v
    }
}
