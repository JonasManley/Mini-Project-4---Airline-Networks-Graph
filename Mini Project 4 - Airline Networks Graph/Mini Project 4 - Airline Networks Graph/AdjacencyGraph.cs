using java.lang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    public class AdjacencyGraph : IGraph
    {
        private readonly int V;
        private int E = 0;
        private readonly EdgeNode[] vertices;

        public void AddUndirectedEdge(int v, int w)
        {
            addEdge(v, w);
            addEdge(w, v);
        }

        public AdjacencyGraph(int V)
        {
            this.V = V;
            vertices = new EdgeNode[V];
        }

        public class EdgeNode
        {
            public int v;
            public EdgeNode next;

            public EdgeNode(int v, EdgeNode next)
            {
                this.v = v;
                this.next = next;
            }
        }


        public int getV() { return V; }


        public int getE() { return E; }


        public void addEdge(int v, int w)
        {
            EdgeNode node = new EdgeNode(w, vertices[v]);
            vertices[v] = node;
            E++;
        }


        public IEnumerable<int> adjacents(int v)
        {
            List<int> adjacents = new List<int>();
            EdgeNode node = vertices[v];
            while (node != null)
            {
                adjacents.Add(node.v);
                node = node.next;
            }
            return adjacents;
        }


        
       
        public override string ToString()
        {
            string text = "";
            for (int v = 0; v < V; v++)
            {
                text += "" + v + ": " + "[" + string.Join(" ", adjacents(v).ToArray())+ "]" + "\n";  //adjacents(v) [1,2]
            }
            return text;
        }

        //public override string ToString()
        //{
        //    string text = "";
        //    for (int v = 0; v < V; v++)
        //    {
        //        text += "" + v + ": " + adjacents(v).ToString() + "\n";  //adjacents(v) [1,2]
        //    }
        //   return text;
        //}
    }
}
 
