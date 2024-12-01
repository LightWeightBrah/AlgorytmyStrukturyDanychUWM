using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreGraphs
{
    public class Edge
    {
        public NodeGA start;
        public NodeGA end;
        public int weight;

        public Edge(NodeGA start, NodeGA end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }
    }

}
