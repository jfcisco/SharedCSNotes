using System;

namespace Ex03StacksQueues
{
    /// <summary>Queue data structure implemented using arrays.</summary>
    public class ArrayQueue
    {
        public string[] Data { get; set; }
        private int _head;
        private int _tail;
        private int _length;
        
        public ArrayQueue(int length)
        {
            Data = new string[length];
            
            _length = length;
            // Initialize Head and Tail to last index of Data.
            _head = length - 1;
            _tail = length - 1;
        }

        /// <summary>Inserts an item at the back of the queue.</summary>
        public void Insert(string dataToInsert)
        {
            if (_head == _tail && Data[_tail] != null)
            {
                throw new Exception("Queue overflow.");
            }

            Data[_tail] = dataToInsert;
            
            if (_tail == _length - 1)
            {
                _tail = 0;
            }
            else
            {
                _tail += 1;
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
            if (_head == _tail && Data[_head] == null)
            {
                throw new Exception("Queue underflow.");
            }

            // Temporarily store data to be returned later on, then set head to null.
            string dataAtHead = Data[_head];
            Data[_head] = null;

            // Move head to next item
            if (_head == _length - 1)
            {
                _head = 0;
            }
            else
            {
                _head += 1;
            }

            return dataAtHead;

        }
    }
}