using System;

namespace Ex03StacksQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformQueueExercises();
        }

        static void PerformQueueExercises()
        {
            var registrants = new ArrayQueue(5);

            registrants.Insert("Harold");
            registrants.Insert("Brunhilde");
            registrants.Insert("Gunther");
            
            registrants.Insert("Siegfried");
            registrants.Insert("Martha");

            // registrants.Insert("Maria");

            string firstInLine = registrants.Remove();
            Console.WriteLine(firstInLine);
                
            firstInLine = registrants.Remove();
            Console.WriteLine(firstInLine);

            registrants.Insert("Jacques");

            foreach(string registrant in registrants.Data)
            {
                if (registrant != null)
                {
                    Console.WriteLine($"{registrant} is a registrant!");
                }
            }
        }

        static void PerformStackExercises()
        {
            var listOfStudents = new ArrayStack(3);
            listOfStudents.Push("Alice");
            listOfStudents.Push("Bob");
            
            string lastInserted = listOfStudents.Pop();
            Console.WriteLine($"The last inserted student was { lastInserted }.");

            lastInserted = listOfStudents.Pop();
            Console.WriteLine($"The last inserted student was { lastInserted }.");

            // Test stack underflow error
            try
            {
                listOfStudents.Pop();
            }
            catch (StackUnderflowException e)
            {
                Console.WriteLine("Action failed successfully.");
                Console.WriteLine(e.Message);
            }

            // Test stack overflow error
            listOfStudents.Push("Calvin");
            listOfStudents.Push("Delphine");
            listOfStudents.Push("Engelbert");

            try
            {
                listOfStudents.Push("Failure");
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("Action failed successfully.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
