/*
 * Julia MacIsaac
 * CPT_244_001
 * Mr. Thomas
 * SingleLinkedList
 */

using System;

namespace Single_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordered List Test\n");

            OrderedList OL = new OrderedList();

            OL.Insert(45);
            OL.Insert(49);
            OL.Insert(42);
            OL.Insert(48);
            OL.Insert(52);
            OL.Insert(12);
            OL.Insert(100);
            Console.WriteLine(OL.ToString());
            OL.Insert(49);
            Console.WriteLine(OL.ToString());
            OL.Remove(42);
            OL.Remove(49);
            OL.Remove(100);
            OL.Remove(52);
            Console.WriteLine(OL.ToString());

            Console.WriteLine("Press 'q' key to quit.");
            while (Console.Read() != 'q') { }
        }
    }
}
