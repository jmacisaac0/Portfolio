/*
 * Julian MacIsaac
 * CPT_244_001
 * Mr. Thomas
 * SingleLinkedList
 */

using System;

namespace Single_Linked_List
{
    class SingleLinkedList
    {
        //objects of this time are used to store data in the linked list
        public class Node
        {
            public int item { get; set; }
            //the next variable is used to point to the next node in the list
            public Node next { get; set; }

            //nod constructors
            public Node()
            {
                item = 0;
                next = null;
            }
            public Node(int anItem)
            {
                item = anItem;
                next = null;
            }
            public Node(int anItem, Node nextNode)
            {
                item = anItem;
                next = nextNode;
            }

            //overrides tostring() function to print out the data in the node
            public override string ToString()
            {
                return "item = " + item.ToString() + " next = " + next.ToString();
            }
        }

        //the head is the 'front' of the list and does not have a previous node
        //in other words, no node points to it
        private Node head;
        //the tail is the end of the list, its next value is null
        private Node tail;

        //these ae so only derived classes can change the values in node classes
        protected Node Head
        {
            get
            {
                return head;
            }
        }
        protected Node Tail
        {
            get
            {
                return tail;
            }
        }

        //base constructor
        public SingleLinkedList()
        {
            head = null;
            tail = head;
        }

        //insert methods
        public bool Insert(int item, Node prev)
        {
            try
            {
                //the only node with no prev node is head, so if prev is null, insert at head
                //else insert after head
                if (prev == null)
                {
                    return InsertAtHead(item);
                }
                else
                {
                    return InsertAfterHead(item, prev);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in Insert");
                Console.WriteLine(e.Message);
                return false;
            }
        }
        private bool InsertAtHead(int anItem)
        {
            try
            {
                //new node made with passed integer, will be inserted
                Node temp = new Node(anItem, head);

                //if list is empty, then new node will be the tail
                if (head == null && tail == null)
                {
                    tail = temp;
                }

                head = temp;
                //removes pointers from temp node after insertion, leading to its deletion
                temp = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in InsertAtHead()");
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        private bool InsertAfterHead(int item, Node prev)
        {
            try
            {
                Node insert = new Node(item, prev.next);

                //if the previous node is end of list (next is null), then new node will be the tail 
                if (prev.next == null)
                {
                    tail = insert;
                }

                prev.next = insert;
                insert = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in InsertAfterHead()");
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        //searches for node with passed integer data
        public Node Find(int anItem)
        {
            //temp nodes used to iterate through list
            Node curr = head;
            Node prev = null;

            try
            {
                //checks if head node has the right data
                if (head.item == anItem)
                {
                    return head;
                }
                else
                {
                    //checks each node until the correct node is found or end of list is reached
                    while (curr.item != anItem && curr.next != null)
                    {
                        prev = curr;
                        curr = curr.next;
                    }
                }

                if (curr.item == anItem)
                {
                    //if node is found, return the previous node
                    //this is done because of the remove method
                    return prev;
                }
                else
                {
                    //if item isn't found, returns the tail
                    return tail;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in Find()");
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                //just in case, prepare temp variables to be deleted
                prev = null;
                curr = null;
            }
        }

        //remove methods
        //finds node with item and removes it
        public bool Remove(int item)
        {
            try
            {
                //uses find method to find the right node (node before found item is returned)
                Node prev = Find(item);

                //calls a method based on whether found node was the head node or not
                if (prev == head)
                {
                    if (head.item == item)
                    {
                        return RemoveAtHead();
                    }
                    else if (prev != tail)
                    {
                        return RemoveAfterHead(prev);
                    }
                }
                else if (prev != tail)
                {
                    RemoveAfterHead(prev);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in Remove()");
                Console.WriteLine(e.Message);
                return false;
            }
            //if node wasn't found, nothing is done
            /*if find returns the tail, that means node was not in the list, because it either returns head
             * or the node before the found item. Find always returns something, so the case in which nothing 
             * is found the prev node should be equal to the tail
             */
            return true;
        }
        private bool RemoveAtHead()
        {
            try
            {
                //list already empty
                if (head == null)
                {
                    return true;
                }
                else
                {
                    //the node after head is now the head, since the curretn head has been deleted
                    Node deleteItem = head;
                    head = deleteItem.next;

                    //if there is only one node in the list
                    if (head == null && tail != null)
                    {
                        tail = head;
                    }

                    //deletes previous head
                    deleteItem = null;
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in RemoveAtHead()");
                Console.WriteLine(e.Message);
                return false;
            }
        }
        private bool RemoveAfterHead(Node prev)
        {
            try
            {
                if (prev == null)
                {
                    return true;
                }
                else
                {
                    //find returns previous node, so prev.next is deleted
                    Node deleteItem = prev.next;
                    //connects the node before the deleted node to the one after
                    prev.next = deleteItem.next;
                    deleteItem.next = null;

                    //if tail is deleted, make the previous node the tail
                    if (tail == deleteItem)
                    {
                        tail = prev;
                    }
                    deleteItem = null;
                    prev = null;
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something broke in RemoveAfterHead()");
                Console.WriteLine(e.Message);
                return false;
            }
        }

        //another tostring override. this one displays the list in order from head to tail
        public override string ToString()
        {
            Node curr = head;
            string list = "";
            while (curr.next != null)
            {
                list = list + curr.item.ToString() + "->";
                curr = curr.next;
            }

            return list + curr.item.ToString();
        }
    }
}
