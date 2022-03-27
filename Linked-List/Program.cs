using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");

            Linked_List linked_list = new Linked_List();
            Node node_one = new Node(56);
            Node node_two = new Node(30);
            Node node_three = new Node(70);

            linked_list.AppendNode(node_one);
            linked_list.AppendNode(node_three);

            linked_list.Display();

            Console.Write("Enter the previous value: ");
            int Prev_Data = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the next value: ");
            int Next_Data = Convert.ToInt32(Console.ReadLine());
            linked_list.AddBetween(Prev_Data, Next_Data, node_two);
            linked_list.Display();
        }
    }
}