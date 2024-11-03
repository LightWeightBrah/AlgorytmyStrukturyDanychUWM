using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinarySearchTree
{
    public partial class MainForm : Form
    {
        private BinarySearchTree bst;
        private TextBox inputBox;
        private Button addButton;
        private Button deleteButton;

        public MainForm()
        {
            this.InitializeComponent();
            this.bst = new BinarySearchTree(10);

            this.Text = "Simple Binary Search Tree";
            this.Size = new Size(600, 400);

            this.inputBox = new TextBox();
            this.inputBox.Location = new Point(10, 10);
            this.inputBox.Width = 50;

            this.addButton = new Button();
            this.addButton.Text = "Add";
            this.addButton.Location = new Point(70, 10);
            this.addButton.Click += this.OnAddButtonClick;

            this.deleteButton = new Button();
            this.deleteButton.Text = "Delete";
            this.deleteButton.Location = new Point(130, 10);
            this.deleteButton.Click += this.OnDeleteButtonClick;

            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Paint += this.OnPaint;
        }

        private void OnDeleteButtonClick(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(this.inputBox.Text, out value))
            {
                this.bst.Delete(value);
                this.Invalidate();
                this.inputBox.Clear();
            }
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(this.inputBox.Text, out value))
            {
                this.bst.Add(value);
                this.Invalidate();
                this.inputBox.Clear();
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (this.bst.root != null)
            {
                this.DrawNode(e.Graphics, this.bst.root, 300, 30, 100);
            }
        }

        private void DrawNode(Graphics g, Node node, int x, int y, int offset)
        {
            if (node == null) return;

            g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30);
            g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
            g.DrawString(node.value.ToString(), new Font("Arial", 10), Brushes.Black, x - 10, y - 10);

            if (node.left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - offset, y + 50);
                this.DrawNode(g, node.left, x - offset, y + 50, offset / 2);
            }

            if (node.right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + offset, y + 50);
                this.DrawNode(g, node.right, x + offset, y + 50, offset / 2);
            }
        }
    }
}