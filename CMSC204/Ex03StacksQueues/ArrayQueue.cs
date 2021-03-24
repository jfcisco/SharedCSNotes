using System;

namespace Ex03StacksQueues
{
    /// <summary>Queue data structure implemented using arrays.</summary>
    public class ArrayQueue
    {
        public string[] Data { get; set; }
        int Head;
        int Tail;
        
        public ArrayQueue(int size)
        {
            Data = new string[size];
            
            // Initialize Head and Tail to last index of Data.
            Head = size - 1;
            Tail = size - 1;
        }

        /// <summary>Inserts an item at the back of the queue.</summary>
        public void Insert(string dataToInsert)
        {
            if (Head == Tail && Data[Tail] != null)
            {
                throw new Exception("Queue overflow.");
            }

            Data[Tail] = dataToInsert;
            
            if (Tail == Data.Length - 1)
            {
                Tail = 0;
            }
            else
            {
                Tail += 1;
            }

            /* 
            Textbook Implementation
             
            if (Tail == Data.Length - 1)
            {
                Tail =  0;
            }
            else
            {
                Tail++;
            }

            if (Tail != Head)
            {
                Data[Tail] = dataToInsert;
            }
            else
            {
                throw new Exception("Queue overflow.");
            } */
        }

        /// <summary>Returns and removes the item at the front of the queue.</summary>
        public string Remove()
        {
            if (Head == Tail && Data[Head] == null)
            {
                throw new Exception("Queue underflow.");
            }

            // Temporarily store data to be returned later on, then set head to null.
            string dataAtHead = Data[Head];
            Data[Head] = null;

            // Move head to next item
            if (Head == Data.Length - 1)
            {
                Head = 0;
            }
            else
            {
                Head += 1;
            }

            return dataAtHead;

        }
    }
}