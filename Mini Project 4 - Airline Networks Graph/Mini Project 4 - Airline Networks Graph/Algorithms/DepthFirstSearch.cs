using java.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    public class DepthFirstSearch
    {
        private readonly IGraph graph;
        private int[] visitedFrom;
        private Stack<Edge> edges;

        public DepthFirstSearch(IGraph graph)
        {
            this.graph = graph;
            visitedFrom = new int[graph.getV()];
            for (int v = 0; v < visitedFrom.Length; v++) visitedFrom[v] = -1;
            edges = new ArrayStack<Edge>(1_000);
        }

        private void register(Edge edge)
        {
            if (visitedFrom[edge.to] != -1) return;
            // only register if 'to' has not been registered already
            edges.push(edge);
            visitedFrom[edge.to] = edge.from;
        }

        public void searchFrom(int v)
        {
            register(new Edge(v, v));
            while (edges.Count() < 0)
            {
                Edge step = edges.pop();
                
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

        public void Print()
        {
            for (int v = 0; v < graph.getV(); v++)
            {
                System.Console.WriteLine("" + v + ": " + showPathTo(v));
            }
        }
    }
}
