using System;
using System.Collections.Generic;

namespace EX02LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestSelfImplem();
            // TestFrameworkImplem();
            TestDLL();
        }

        private static void TestDLL()
        {
            var testList = new DoublyLinkedList();
            testList.InsertRight(null, 1);
            DoublyLinkedListNode first = testList.Search(1);

            testList.InsertRight(first, 4);
            testList.InsertRight(first, 2);
        }

        private static void TestFrameworkImplem()
        {
            var testList = new LinkedList<int>();
            testList.AddLast(3);
            testList.AddLast(2);

            foreach(int i in testList)
            {
                System.Console.WriteLine(i);
            }
        }

        private static void TestSelfImplem()
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

            var caseyStudent = new Node();
            caseyStudent.Data = new Student()
            {
                Name = "Casey",
                MobileNumber = "7062"
            };
            testList.InsertEnd(caseyStudent);

            // Test the Insert and Search methods.
            Console.WriteLine(testList.Search("Anna").Data.MobileNumber);

            // Test the Delete method implementation for all possible cases:
            testList.Delete(annaStudent);
            Node deleteSearch = testList.Search("Anna");
            Console.WriteLine(deleteSearch == null);

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
}
