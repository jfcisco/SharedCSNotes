using System;

namespace EX02LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var testList = new LinkedList();
            
            var annaStudent = new Node();
            annaStudent.Data = new Student();
            annaStudent.Data.Name = "Anna";
            annaStudent.Data.MobileNumber = "0908";

            testList.InsertEnd(annaStudent);

            var bobStudent = new Node();
            bobStudent.Data = new Student();
            bobStudent.Data.Name = "Bob";
            bobStudent.Data.MobileNumber = "8132";

            testList.InsertEnd(bobStudent);

            // Test the Insert and Search methods.
            Console.WriteLine(testList.Search("Anna").Data.MobileNumber);

            // Test the Delete method implementation for all possible cases:

            /*
                Cases to consider:
                ○ The list is empty;
                ○ The node to remove is the only node in the linked list;
                ○ We are removing the head node;
                ○ We are removing the tail node;
                ○ The node to remove is somewhere in between the head and tail;
                ○ The item to remove doesn’t exist in the linked list
            */
        }
    }

    public class Node
    {
        public Student Data { get; set; }
        public Node Next; // defaults to null
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nickname { get; set; }
        public string MobileNumber { get; set; }
    }

    public class LinkedList
    {
        protected Node Header { get; set; } // What does protected do?
        protected Node Tail { get; set; } // What does get; set; do?

        public LinkedList()
        {
            Header = null;
            Tail = null;
        }

        public void InsertEnd(Node newNode)
        {
            // If inserting for the first time, head = tail = newNode
            if (Header == null)
            {
                Header = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        /// <summary>Searches for a specific Node in the LinkedList whose Student matches the name.</summary>
        public Node Search(string studentName)
        {
            Node current = Header;

            while ((current != null) && (current.Data.Name != studentName))
            {
                current = current.Next;
            }

            return current;
        }

        /// <summary>Returns the Node just before the given Node.</summary>
        public Node GetPreviousNode(Node node)
        {
            Node previousNode = Header;

            if (Header == node)
            {
                previousNode = null;
            }
            else
            {
                while ((previousNode != null) && (previousNode.Next != node))
                {
                    previousNode = previousNode.Next;
                }
            }
            
            return previousNode;
        }

        /// Deletes the given Node in the linked list
        public void Delete(Node nodeToDelete)
        {
            // List is empty -> Do nothing.
            if (Header != null)
            {
                if (Header == nodeToDelete)
                {
                    // Node to remove is the only node -> reset Header and Tail to null
                    if (Header == Tail)
                    {
                        Header = null;
                        Tail = null;
                    }
                    // Removing head node -> set Header to the current Header.Next
                    else
                    {
                        Header = Header.Next;
                    }
                }
                // Removing tail node -> set Tail to Node just before the tail (need to search)
                else if (Tail == nodeToDelete)
                {
                    Tail = GetPreviousNode(Tail);
                }
                else
                {
                    // Node is either in the middle or not in the list
                    Node beforeDelete = GetPreviousNode(nodeToDelete);

                    if (beforeDelete != null)
                    {
                        beforeDelete.Next = nodeToDelete.Next;
                    }

                    // Item doesn't exist in the linkedList -> Do nothing.
                }               
            }
            
        }
    }
}
