using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree(int value)
        {
            this.root = new Node(value);
        }

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (this.root == null)
            {
                this.root = newNode;
                return;
            }

            Node current = this.root;
            Node parent = null;

            while (current != null)
            {
                parent = current;

                if (value < current.value)
                {
                    current = current.left;
                }
                else if (value > current.value)
                {
                    current = current.right;
                }
                else
                {
                    return;
                }
            }

            if (value < parent.value)
            {
                parent.left = newNode;
            }
            else
            {
                parent.right = newNode;
            }

            newNode.parent = parent;
        }

        public void Delete(int value)
        {
            this.root = this.DeleteNode(this.root, value);
        }

        private Node DeleteNode(Node root, int value)
        {
            if (root == null) return root;

            if (value < root.value)
            {
                root.left = this.DeleteNode(root.left, value);
            }
            else if (value > root.value)
            {
                root.right = this.DeleteNode(root.right, value);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }

                root.value = this.MinValue(root.right);

                root.right = this.DeleteNode(root.right, root.value);
            }

            return root;
        }

        private int MinValue(Node node)
        {
            int minValue = node.value;
            while (node.left != null)
            {
                node = node.left;
                minValue = node.value;
            }
            return minValue;
        }

    }
}
