using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmDijkstry
{
    public class Edge
    {
        public int start;
        public int end;
        public int weight;

        public Edge(int start, int end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }
    }

}
