using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        public List<NodeG> nodes;

        public Graph()
        {
            this.nodes = new List<NodeG>();
        }

        public void AddNode(NodeG node)
        {
            this.nodes.Add(node);
        }

        public void AddEdge(NodeG from, NodeG to)
        {
            from.neighbors.Add(to);
        }

        public void DrawGraph(Graphics g)
        {
            Pen edgePen = new Pen(Color.Black, 2);
            Brush nodeBrush = Brushes.LightBlue;
            Brush textBrush = Brushes.Black;
            Font font = new Font("Arial", 12);

            foreach (var node in this.nodes)
            {
                foreach (var neighbor in node.neighbors)
                {
                    g.DrawLine(edgePen, node.position, neighbor.position);
                }
            }

            foreach (var node in this.nodes)
            {
                int nodeSize = 30;
                var rect = new Rectangle(
                    node.position.X - nodeSize / 2,
                    node.position.Y - nodeSize / 2,
                    nodeSize,
                    nodeSize);

                g.FillEllipse(nodeBrush, rect);
                g.DrawEllipse(Pens.Black, rect);

                var textSize = g.MeasureString(node.data.ToString(), font);
                var textPosition = new PointF(
                    node.position.X - textSize.Width / 2,
                    node.position.Y - textSize.Height / 2);
                g.DrawString(node.data.ToString(), font, textBrush, textPosition);
            }
        }

    }
}
