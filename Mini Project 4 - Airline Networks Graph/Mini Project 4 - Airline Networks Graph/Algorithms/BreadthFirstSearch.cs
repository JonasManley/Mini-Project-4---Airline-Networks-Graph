using com.sun.corba.se.impl.orbutil.graph;
using Mini_Project_4___Airline_Networks_Graph.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph.Algorithms
{
    public class BreadthFirstSearch
    {
        private readonly IGraph graph;
        private int[] visitedFrom;
        private Queue<Edge> edges;

        public BreadthFirstSearch(IGraph graph)
        {
            this.graph = graph;
            visitedFrom = new int[graph.getV()];
            for (int v = 0; v < visitedFrom.Length; v++) visitedFrom[v] = -1;
            edges = new ArrayQueue<Edge>(1_000);
        }


        private void register(Edge edge)
        {
            if (visitedFrom[edge.to] != -1) return;
            // only register if 'to' has not been registered already
            edges.Enqueue(edge);
            visitedFrom[edge.to] = edge.from;
        }

        public void searchFrom(int v)
        {
            register(new Edge(v, v));
            while (edges.Count() > 0)
            {
                Edge step = edges.Dequeue();

                foreach (var w in graph.adjacents(step.to))
                {
                    register(new Edge(step.to, v));
                }
            }
        }

        public String showPathTo(int w)
        {
            String path = "" + w;
            while (visitedFrom[w] != w && visitedFrom[w] != -1)
            {
                w = visitedFrom[w];
                path = "" + w + " -> " + path;
            }
            return path;
        }


        public override string ToString()
        {
            string text = "";
            for (int v = 0; v < graph.getV(); v++)
            {
                text += "" + v + ": " + "[" + string.Join(" ", showPathTo(v).ToArray()) + "]" + "\n";  //adjacents(v) [1,2]
            }
            return text;
        }

    }
}

