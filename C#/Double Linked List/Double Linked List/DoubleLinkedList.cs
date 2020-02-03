/*
 * Julia MacIsaac
 * CPT_244_001
 * Mr. Thomas
 * DoubleLinkedList
 */

using System;

namespace Double_Linked_List
{
    class DoubleLinkedList
    {
        //node store data and point to both the previous and next nodes in the list
        public class Node
        {

            public int item { get; set; }
            public Node next { get; set; }
            public Node previous { get; set; }

            public Node()
            {
                item = 0;
                next = null;
                previous = null;
            }
            public Node(int anItem)
            {
                item = anItem;
                next = null;
                previous = null;
            }
            public Node(int anItem, Node nextNode)
            {
                item = anItem;
                next = nextNode;
                previous = null;
            }

            public override string ToString()
            {
                return "item = " + item.ToString() + " next = " + next.ToString() + " prev = " + previous.ToString();
            }
        }

        private Node head { get; set; }
        private Node tail { get; set; }
        
        //base constructor
        public DoubleLinkedList()
        {
            head = null;
            tail = head;
        }

        //ordered insert method overload
        //this method does not have a node parameter because it will decide where the passed data will go
        public bool Insert(int item)
        {
            try
            {
                Node curr = head;

                //if list isn't empty
                if (curr != null)
                {
                    //iterate through until passed data is larger than previous node
                    while (curr.next != null && curr.item < item)
                    {
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
                        Insert(item, curr.previous);
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
        //insert methods
        public bool Insert(int item, Node prev)
        {
            try
            {
                //the head nodes location is always known, so the node before it isn't required
                //additionally, the head shouldn't have a previous node
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
        //creates a new node
        private bool InsertAtHead(int anItem)
        {
            try
            {
                Node temp = new Node(anItem, head);

                //if there are no nodes in the list, make new node the tail as well as the head
                if (head == null && tail == null)
                {
                    tail = temp;
                }

                head = temp;
                //if there is more than one node, make the new head's next pointer point to the original head
                if (head.next != null)
                {
                    head.next.previous = head;
                }
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
        //creates new node after the prev pointer
        private bool InsertAfterHead(int item, Node prev)
        {
            try
            {
                //change the previous nodes next pointer and next nodes previous pointer to point to new node
                Node insert = new Node(item, prev.next); 
                insert.previous = prev;
                if (insert.next != null)
                {
                    insert.next.previous = insert;
                }

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
                    //the node after head is now the head, since the current head has been deleted
                    Node deleteItem = head;
                    head = deleteItem.next;
                    head.previous = null;

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
                    //connexts the node after the deleted to the one before
                    if (deleteItem.next != null)
                    {
                        deleteItem.next.previous = deleteItem.previous;
                    }

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
        //worls like the tostring override method, but instead prints starting at the tail and moving backwards
        public string ToStringReverse()
        {
            Node curr = tail;
            string list = "";
            //uses the previous pointers to move backward
            while (curr.previous != null)
            {
                list = list + curr.item.ToString() + "->";
                curr = curr.previous;
            }

            return list + curr.item.ToString();
        }
    }
}
