using GraphQL.Types.Relay.DataObjects;
using java.lang;
using Microsoft.JScript;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mini_Project_4___Airline_Networks_Graph
{
    public class EdgeWeightedDigraph
    {
        private int v;                                    // number of vertices   
        private int edge;                                 // number of edges   
        private ConcurrentBag<DirectedEdge>[] adjArray;   // adjacency lists  

        public EdgeWeightedDigraph(int V)
        {
            this.v = V;
            this.edge = 0;
            this.adjArray = new ConcurrentBag<DirectedEdge>[v];
            for (int v = 0; v < V; v++)
            {
                adjArray[v] = new ConcurrentBag<DirectedEdge>();
            }
        }

        public EdgeWeightedDigraph()
        {

        }  

        public int V() { return v; }
        public int E() { return edge; }

        public void addEdge(DirectedEdge directedEdge) 
        {
            adjArray[directedEdge.from()].Add(directedEdge); edge++; 
        }

        public IEnumerable<DirectedEdge> adj(int v) 
        { 
            return adjArray[v]; 
        }

        public IEnumerable<DirectedEdge> Edges() 
        {
            ConcurrentBag<DirectedEdge> bag = new ConcurrentBag<DirectedEdge>();

            for (int v = 0; v < V(); v++) {
                foreach (var edge in adjArray[v])
                {
                    bag.Add(edge);
                }
            }
            return bag;
        }

    }
}
