using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public Node tail;

        private Node currentNode;

        public LinkedList()
        {

        }

        public LinkedList(int[] values)
        {
            this.CreateList(values);
        }

        public void CreateList(int[] values)
        {
            this.head = new Node {value = values[0] };
            this.currentNode = this.head;

            for (int i = 1; i < values.Length; i++)
            {
                Node newNode = new Node { value = values[i], previous = this.currentNode };
                this.currentNode.next = newNode;

                this.currentNode = newNode;
            }

            this.tail = this.currentNode;
        }

        public void PrintList()
        {
            string list = "";
            this.currentNode = this.head;

            while(this.currentNode != null)
            {
                list += $"{this.currentNode.value} ";
                this.currentNode = this.currentNode.next;
            }

            MessageBox.Show(list);
        }

        public void AddFirst(int value)
        {
            Node oldHead = this.head;
            Node newHead = new Node { value = value, next = oldHead };
            this.head = newHead;
        }

        public void AddFirst(int[] values)
        {
            for(int i = values.Length - 1; i >= 0; i--)
            {
                this.AddFirst(values[i]);
            }
        }

        public void AddLast(int value)
        {
            Node newTail = new Node { value = value, previous = this.tail };
            this.tail.next = newTail;
            this.tail = newTail;
        }

        public void AddLast(int[] values)
        {
            for(int i = 0; i < values.Length; i++)
            {
                this.AddLast(values[i]);
            }
        }

        public void RemoveFirst()
        {
            this.head = this.head.next;
        }

        public void RemoveLast()
        {
            this.tail.previous.next = null;  
        }

        public string ToString()
        {
            string list = "";
            this.currentNode = this.head;

            while (this.currentNode != null)
            {
                list += $"{this.currentNode.value} ";
                this.currentNode = this.currentNode.next;
            }

            return list;
        }

        public int[] ToArray()
        {
            List<int> list = new List<int>();
            this.currentNode = this.head;

            while (this.currentNode != null)
            {
                list.Add(this.currentNode.value);
                this.currentNode = this.currentNode.next;
            }

            return list.ToArray();
        }
    }
}
