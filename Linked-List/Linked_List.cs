﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Linked_List
    {
        public Node Head;
        public Node Tail;

        public Linked_List()
        {
            Head = null;
            Tail = null;
        }
        public void Display()
        {
            Node temp = Head;

            if (temp == null)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                Console.WriteLine("List is as follows");
                while (temp != null)
                {
                    Console.Write(temp.Data);
                    if (temp.Next != null)
                    {
                        Console.Write(" -> ");
                    }
                    temp = temp.Next;
                }
                Console.WriteLine("\n");
            }
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }

        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
        public void AddBetween(int Prev_Data, int Next_Data, Node node)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Data == Prev_Data && temp.Next.Data == Next_Data)
                {
                    node.Next = temp.Next;
                    temp.Next = node;
                    break;
                }
                temp = temp.Next;
            }
        }
    }
}
