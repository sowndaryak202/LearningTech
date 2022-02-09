using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinaryTree<T>
    {
        Node<T> head = null;

        public Node<T> AddNode(T value)
        {
            if (head == null)
            {
                head = new Node<T>();
                head.Data = value;
                head.rightNode = null;
                head.LeftNode = null;
            }
            else
            {
                AddChildNode(head, value);
            }
            return head;
        }

        private void AddChildNode(Node<T> node, T value)
        {
            if (IsNodeavailable(node))
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new Node<T>();
                    node.LeftNode.Data = value;
                }

                else if (node.rightNode == null)
                {
                    node.rightNode = new Node<T>();
                    node.rightNode.Data = value;
                }

                return;
            }

            Node<T> _nextNode = IsNodeavailable(node.LeftNode) ? node.LeftNode : node.rightNode;

            AddChildNode(_nextNode, value);
        }

        private bool IsNodeavailable(Node<T> node)
        {
            return node.LeftNode == null || node.rightNode == null;
        }

    }

    public class Node<T>
    {
        public Node<T> rightNode;
        public Node<T> LeftNode;
        public T Data;
    }

}
