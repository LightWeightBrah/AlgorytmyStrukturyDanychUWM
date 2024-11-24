using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class NodeG
    {
        public int data;
        public List<NodeG> neighbors;
        public Point position;

        public NodeG(int data, Point position)
        {
            this.data = data;
            this.neighbors = new List<NodeG>();
            this.position = position;
        }
    }
}
