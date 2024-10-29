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
    }
}
