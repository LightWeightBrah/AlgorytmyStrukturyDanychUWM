using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreGraphs
{
    public class GraphGA
    {
        public List<NodeGA> nodes = new List<NodeGA>();
        public List<Edge> edges = new List<Edge>();

        public void Add(Edge e)
        {
            this.edges.Add(e);

            if (!this.nodes.Contains(e.start)) 
                this.nodes.Add(e.start);

            if (!this.nodes.Contains(e.end))
                this.nodes.Add(e.end);
        }

        public int HowManyNewNodes(Edge k)
        {
            int newnodes = 0;

            if (!this.nodes.Contains(k.start)) 
                newnodes++;

            if (!this.nodes.Contains(k.end)) 
                newnodes++;

            return newnodes;
        }

        public void Join(GraphGA q)
        {
            foreach (var edge in q.edges)
            {
                this.Add(edge);
            }
        }

        public int IsNodeLinked(Edge e)
        {
            return this.nodes.Contains(e.start) && this.nodes.Contains(e.end) ? 1 : 0;
        }
    }

}
