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
}
