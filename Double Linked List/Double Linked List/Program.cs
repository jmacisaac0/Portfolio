/*
 * Julian MacIsaac
 * CPT_244_001
 * Mr. Thomas
 * DoubleLinkedList
 */

using System;

namespace Double_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Double Linked List Test\n");

            DoubleLinkedList DL = new DoubleLinkedList();

            DL.Insert(45);
            DL.Insert(49);
            DL.Insert(42);
            DL.Insert(48);
            DL.Insert(52);
            DL.Insert(12);
            DL.Insert(100);
            Console.WriteLine(DL.ToString());
            Console.WriteLine(DL.ToStringReverse());
            DL.Insert(49);
            Console.WriteLine(DL.ToString());
            Console.WriteLine(DL.ToStringReverse());
            DL.Remove(42);
            DL.Remove(49);
            DL.Remove(100);
            DL.Remove(52);
            Console.WriteLine(DL.ToString());
            Console.WriteLine(DL.ToStringReverse());

            Console.WriteLine("Press 'q' key to quit.");
            while (Console.Read() != 'q') { }
        }
    }
}
