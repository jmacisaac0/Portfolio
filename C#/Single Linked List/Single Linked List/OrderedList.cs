/*
 * Julia MacIsaac
 * CPT_244_001
 * Mr. Thomas
 * SingleLinkedList
 */

using System;

namespace Single_Linked_List
{
    class OrderedList : SingleLinkedList
    {
        public OrderedList() : base()
        {

        }

        //singlelinkedlist insert method overload
        //this method does not have a node parameter because it will decide where the passed data will go
        public bool Insert(int item)
        {
            try
            {
                Node prev = null;
                Node curr = Head;

                //if list isn't empty
                if (curr != null)
                {
                    //iterate through until passed data is larger than previous node
                    while (curr.next != null && curr.item < item)
                    {
                        prev = curr;
                        curr = curr.next;
                    }
                    //if the passed item is greater than anything else in the list, place at end
                    //this requires it to be placed after the current node, rather than before it
                    if (curr.next == null && curr.item < item)
                    {
                        Insert(item, curr);
                    }
                    else
                    {
                        Insert(item, prev);
                    }
                }
                else
                {
                    //insert at head if list is empty
                    Insert(item, null);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in Insert");
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
