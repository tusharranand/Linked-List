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
            linked_list.AppendNode(node_two);
            linked_list.AppendNode(node_three);

            linked_list.Display();

            Console.Write("Enter the number you want to find: ");
            int Data = Convert.ToInt32(Console.ReadLine());
            bool Result = linked_list.Search(Data);
            if (Result)
                Console.WriteLine("Data exists in the linked list.\n");
            else
                Console.WriteLine("Data does not exist in the linked list.\n");
        }
    }
}