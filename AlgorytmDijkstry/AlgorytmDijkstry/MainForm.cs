using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlgorytmDijkstry
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        private List<Node> nodes = new List<Node>();
        private List<Edge> edges = new List<Edge>();
        private List<Edge> shortestPathEdges = new List<Edge>();

        public MainForm()
        {
            this.InitializeComponent();
            this.MouseClick += this.OnMouseLeftButtonClick;
        }

        private void OnMouseLeftButtonClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Node newNode = new Node(this.nodes.Count, e.X, e.Y);
                this.nodes.Add(newNode);

                foreach (var existingNode in this.nodes)
                {
                    if (existingNode.id != newNode.id)
                    {
                        if (this.random.Next(0, 2) == 1)
                        {
                            int weight = this.random.Next(1, 11);
                            this.edges.Add(new Edge(newNode.id, existingNode.id, weight));
                            this.edges.Add(new Edge(existingNode.id, newNode.id, weight));
                        }
                    }
                }

                this.Invalidate();
            }
        }

        private void RunDijkstry(object sender, EventArgs e)
        {
            if (this.nodes.Count == 0 || this.edges.Count == 0)
            {
                MessageBox.Show("Nie stworzyłeś Node'ów i krawędzi!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(this.startNodeTextBox.Text, out int startNode) ||
                !int.TryParse(this.endNodeTextBox.Text, out int endNode) ||
                startNode < 0 || endNode < 0 ||
                startNode >= this.nodes.Count || endNode >= this.nodes.Count)
            {
                MessageBox.Show("Złe dane dla Node start lub Node end!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] distances = new int[this.nodes.Count];
            bool[] visited = new bool[this.nodes.Count];
            int[] previous = new int[this.nodes.Count];

            for (int i = 0; i < this.nodes.Count; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
                previous[i] = -1;
            }
            distances[startNode] = 0;

            for (int i = 0; i < this.nodes.Count; i++)
            {
                int currentNode = this.GetClosestNode(distances, visited);
                if (currentNode == -1) break;

                visited[currentNode] = true;

                foreach (var edge in this.edges)
                {
                    if (edge.start == currentNode && !visited[edge.end])
                    {
                        int newDistance = distances[currentNode] + edge.weight;
                        if (newDistance < distances[edge.end])
                        {
                            distances[edge.end] = newDistance;
                            previous[edge.end] = currentNode;
                        }
                    }
                }
            }

            if (distances[endNode] == int.MaxValue)
            {
                this.resultLabel.Text = "Brak ścieżki!";
                return;
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Najkrótsza droga z Node {startNode} do Node {endNode}");
            result.AppendLine($"Łączna waga ścieżki: ({distances[endNode]})");

            List<int> path = new List<int>();
            int current = endNode;
            while (current != -1)
            {
                path.Add(current);
                current = previous[current];
            }
            path.Reverse();

            result.AppendLine("Ścieżka: " + string.Join(" -> ", path));
            this.resultLabel.Text = result.ToString();

            this.shortestPathEdges.Clear();
            for (int i = 0; i < path.Count - 1; i++)
            {
                this.shortestPathEdges.Add(this.edges.Find(edge => edge.start == path[i] && edge.end == path[i + 1]));
            }

            this.Invalidate();
        }

        private int GetClosestNode(int[] distances, bool[] visited)
        {
            int minDistance = int.MaxValue;
            int closestNode = -1;

            for (int i = 0; i < distances.Length; i++)
            {
                if (!visited[i] && distances[i] < minDistance)
                {
                    minDistance = distances[i];
                    closestNode = i;
                }
            }

            return closestNode;
        }

        private void ResetGraph(object sender, EventArgs e)
        {
            this.nodes.Clear();
            this.edges.Clear();
            this.shortestPathEdges.Clear();
            this.resultLabel.Text = "Najkrótsza droga: ";
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            base.OnPaint(paintEventArgs);
            Graphics g = paintEventArgs.Graphics;

            Font largerFont = new Font(this.Font.FontFamily, 12, FontStyle.Bold);

            foreach (var edge in this.edges)
            {
                var startNode = this.nodes[edge.start];
                var endNode = this.nodes[edge.end];

                var pen = this.shortestPathEdges.Contains(edge) ? Pens.Red : Pens.Black;
                g.DrawLine(pen, startNode.x, startNode.y, endNode.x, endNode.y);

                var midPoint = new PointF((startNode.x + endNode.x) / 2, (startNode.y + endNode.y) / 2);
                g.DrawString(edge.weight.ToString(), largerFont, Brushes.Black, midPoint);
            }

            foreach (var node in this.nodes)
            {
                var brush = this.shortestPathEdges.Exists(edge => edge.start == node.id || edge.end == node.id) ? Brushes.Red : Brushes.LightBlue;
                g.FillEllipse(brush, node.x - 15, node.y - 15, 30, 30);
                g.DrawEllipse(Pens.Black, node.x - 15, node.y - 15, 30, 30);

                g.DrawString(node.id.ToString(), largerFont, Brushes.Black, node.x - 10, node.y - 10);
            }

            largerFont.Dispose();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

    }
}
