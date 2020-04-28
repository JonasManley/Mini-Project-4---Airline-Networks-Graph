using Mini_Project_4___Airline_Networks_Graph.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            //IGraph g = new AdjacencyGraph(6);
            //g.addEdge(0, 1);
            //g.addEdge(0, 2);
            //g.addEdge(2, 0);
            //g.addEdge(2, 3);
            //g.addEdge(2, 4);
            //g.addEdge(3, 4);
            //g.addEdge(3, 5);
            //g.addEdge(5, 0);
            //g.addEdge(5, 3);
            //Console.WriteLine(g);
            //Console.ReadLine();
            ///*
            //  0: [2, 1]
            //  1: []
            //  2: [4, 3, 0]
            //  3: [5, 4]
            //  4: []
            //  5: [3, 0]
            //*/



            //IGraph g = new AdjacencyGraph(11);
            //g.AddUndirectedEdge(0, 5);
            //g.AddUndirectedEdge(0, 1);
            //g.AddUndirectedEdge(0, 2);
            //g.AddUndirectedEdge(2, 3);
            //g.AddUndirectedEdge(2, 4);
            //g.AddUndirectedEdge(3, 4);
            //g.AddUndirectedEdge(5, 3);
            //g.AddUndirectedEdge(0, 7);
            //g.AddUndirectedEdge(0, 8);
            //g.AddUndirectedEdge(0, 9);
            //g.AddUndirectedEdge(9, 10);

            //DepthFirstSearch dfs = new DepthFirstSearch(g);
            //dfs.searchFrom(9);
            //dfs.Print();
            //Console.ReadLine();


            IGraph g = new AdjacencyGraph(6);
            g.AddUndirectedEdge(0, 5);
            g.AddUndirectedEdge(0, 1);
            g.AddUndirectedEdge(0, 2);
            g.AddUndirectedEdge(2, 3);
            g.AddUndirectedEdge(2, 4);
            g.AddUndirectedEdge(3, 4);
            g.AddUndirectedEdge(5, 3);

            BreadthFirstSearch bfs = new BreadthFirstSearch(g);
            bfs.searchFrom(0);
            Console.WriteLine(bfs);
            //bfs.Print();
            Console.ReadLine();
           
        }
    }
}
