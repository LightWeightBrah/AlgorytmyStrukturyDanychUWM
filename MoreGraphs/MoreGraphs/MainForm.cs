namespace MoreGraphs
{
    public partial class MainForm : Form
    {
        private GraphGA graph = new GraphGA();
        private Dictionary<NodeGA, Point> nodePositions = new Dictionary<NodeGA, Point>();
        private Button testFunctionsButton;

        public MainForm()
        {
            this.InitializeComponent();
            this.Init();
            this.InitializeGraph();
        }

        private void InitializeGraph()
        {
            NodeGA n0 = new NodeGA(0);
            NodeGA n1 = new NodeGA(1);
            NodeGA n2 = new NodeGA(2);
            NodeGA n3 = new NodeGA(3);
            NodeGA n4 = new NodeGA(4);
            NodeGA n5 = new NodeGA(5);
            NodeGA n6 = new NodeGA(6);

            this.graph.nodes.AddRange(new[] { n0, n1, n2, n3, n4, n5, n6 });

            this.nodePositions[n0] = new Point(50, 200);
            this.nodePositions[n1] = new Point(100, 50);
            this.nodePositions[n2] = new Point(300, 50);
            this.nodePositions[n3] = new Point(50, 350);
            this.nodePositions[n4] = new Point(200, 200);
            this.nodePositions[n5] = new Point(350, 350);
            this.nodePositions[n6] = new Point(400, 200);

            this.graph.Add(new Edge(n4, n6, 1));
            this.graph.Add(new Edge(n4, n5, 2));
            this.graph.Add(new Edge(n0, n2, 3));
            this.graph.Add(new Edge(n2, n6, 4));
            this.graph.Add(new Edge(n2, n4, 5));
            this.graph.Add(new Edge(n5, n6, 6));
            this.graph.Add(new Edge(n4, n3, 7));
            this.graph.Add(new Edge(n6, n2, 8));
        }

        private void TestFunctions()
        {
            NodeGA n7 = new NodeGA(7);
            Edge newEdge = new Edge(this.graph.nodes[0], n7, 9);

            int newnodes = this.graph.HowManyNewNodes(newEdge);
            MessageBox.Show($"KrawêdŸ dodaje {newnodes} nowe wêz³y.", "Informacja");

            GraphGA anotherGraph = new GraphGA();
            anotherGraph.Add(new Edge(n7, this.graph.nodes[1], 10));
            this.graph.Join(anotherGraph);

            MessageBox.Show("Grafy zosta³y po³¹czone.", "Informacja");

            this.nodePositions[n7] = new Point(250, 300);
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (var edge in this.graph.edges)
            {
                Pen pen = new Pen(Color.Black, 2);
                Point start = this.nodePositions.ContainsKey(edge.start) ? this.nodePositions[edge.start] : new Point(0, 0);
                Point end = this.nodePositions.ContainsKey(edge.end) ? this.nodePositions[edge.end] : new Point(0, 0);
                g.DrawLine(pen, start, end);

                Point mid = new Point((start.X + end.X) / 2, (start.Y + end.Y) / 2);
                g.DrawString(edge.weight.ToString(), DefaultFont, Brushes.Red, mid);
            }

            foreach (var node in this.graph.nodes)
            {
                Brush brush = Brushes.Blue;
                Point pos = this.nodePositions.ContainsKey(node) ? this.nodePositions[node] : new Point(0, 0);
                g.FillEllipse(brush, pos.X - 15, pos.Y - 15, 30, 30);
                g.DrawString(node.data.ToString(), DefaultFont, Brushes.White, pos.X - 10, pos.Y - 10);
            }
        }

        private void Init()
        {
            this.Text = "Graph Visualization";
            this.ClientSize = new Size(500, 400);

            this.testFunctionsButton = new Button();
            this.testFunctionsButton.Text = "Test Functions";
            this.testFunctionsButton.Location = new Point(10, 10);
            this.testFunctionsButton.Click += (sender, e) => this.TestFunctions();
            this.Controls.Add(this.testFunctionsButton);
        }
    }
}
