namespace Graphs
{
    public partial class MainForm : Form
    {
        private Graph graph;

        public MainForm()
        {
            this.InitializeComponent();
            this.graph = new Graph();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var A = new NodeG(1, new Point(100, 200));
            var B = new NodeG(2, new Point(200, 100));
            var C = new NodeG(3, new Point(100, 400));
            var D = new NodeG(4, new Point(300, 200));
            var E = new NodeG(5, new Point(400, 100));
            var F = new NodeG(6, new Point(400, 300));
            var G = new NodeG(7, new Point(500, 400));

            this.graph.AddNode(A);
            this.graph.AddNode(B);
            this.graph.AddNode(C);
            this.graph.AddNode(D);
            this.graph.AddNode(E);
            this.graph.AddNode(F);
            this.graph.AddNode(G);

            this.graph.AddEdge(A, B);
            this.graph.AddEdge(A, D);
            this.graph.AddEdge(B, E);
            this.graph.AddEdge(C, A);
            this.graph.AddEdge(D, F);
            this.graph.AddEdge(E, F);
            this.graph.AddEdge(F, G);

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.graph.DrawGraph(e.Graphics);
        }
    }
}