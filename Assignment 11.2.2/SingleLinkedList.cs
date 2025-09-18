using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11._2._2
{
    internal class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node(int newNode)
        {
            Value = newNode; NextNode = null;
        }
    }
    internal class SingleLinkedList
    {
        private Node head;
        private Node tail;
        public int length;

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.NextNode = head;
                head = newNode;
            }
            length++;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.NextNode = newNode;
                tail = newNode;
            }
            length++;
        }
        public int Search(int value)
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty. Item not found.");
                return 0;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.Value == value)
                    {
                        return temp.Value;
                    }
                    else temp = temp.NextNode;
                }
                return 0;
            }
        }
        public void DisplayAll()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.NextNode != null)
                    {
                        Console.Write($"Number: {temp.Value}-->\n");
                        temp = temp.NextNode;
                    }
                    else
                    {
                        Console.Write($"Number: {temp.Value}");
                        return;
                    }
                }
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty. No items removed.");
            }
            else
            {
                head = head.NextNode;
                if (head == null)
                {
                    tail = null;
                }
                length--; // Decrement
            }
        }
        public void RemoveLast()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty. No items removed.");
            }
            else if (head == tail)
            {
                head = null;
                tail = null;
                length--; // Only one node
            }
            else
            {
                while (temp.NextNode != tail)
                {
                    temp = temp.NextNode;
                }
                tail = temp;
                temp.NextNode = null;
                length--; // Decrement
            }
        }
        public bool Contains(int value)
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty. Item not found.");
                return false;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.Value == value)
                    {
                        return true;
                    }
                    else temp = temp.NextNode;
                }
                return false;
            }
        }
        public void Reverse()
        {
            if (head == null || head.NextNode == null)
                return;

            Node prev = null;
            Node temp = head;
            Node next = null;

            while (temp != null)
            {
                next = temp.NextNode;
                temp.NextNode = prev;
                prev = temp;
                temp = next;
            }

            head = prev;
        }
    }
}