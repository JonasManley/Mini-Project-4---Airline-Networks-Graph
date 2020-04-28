using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_4___Airline_Networks_Graph
{
    public class DirectedEdge
    {
        private readonly int v;                       // edge source  
        private readonly int w;                       // edge target  
        private readonly double weight;               // edge weight   
        public DirectedEdge(int v, int w, double weight)  
        {      
            this.v = v;      
            this.w = w;      
            this.weight = weight;   
        }  

        public double Weight()   { return weight;  }   
        public int from()   {  return v;  }  
        public int to()   {  return w;  }   
        public String toString()   
        {
            return $"@{v} @{w} @{weight}";
        }  
    }

}
