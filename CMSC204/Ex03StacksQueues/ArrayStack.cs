using System;

namespace Ex03StacksQueues
{
    /// <summary>Stack implemented using the array data structure.</summary>
    class ArrayStack
    {
        public string[] Data { get; private set; }
        // Omitting setter because we want the user to modify data only through methods.
        public int Head { get; private set; }
        // Deciding to point the Head property to the first available space.

        public ArrayStack(int size)
        {
            Data = new string[size];
            Head = 0;
        }

        /// <summary>Adds an element to the Stack's head.</summary>
        public void Push(string dataToInsert)
        {
            // Case 1: Push to an empty stack -> Add data to Head
            // Case 2: Push to a half-full stack -> Add data to Head
            // Case 3: Push to a full stack -> throw stackoverflow error
            if (Head < Data.Length)
            {
                Data[Head] = dataToInsert;
                Head++;
            }
            else
            {
                // Using the built-in stack overflow exception.
                throw new StackOverflowException();
            }
        }

        /// <summary>Removes the elements last pushed to the stack and returns it.</summary>
        public string Pop()
        {
            // Case 1: Pop an empty stack. -> throw a stack underflow error.
            // Case 2: Pop a half-full stack. -> remove data at index = Head - 1
            // Case 3: Pop a full stack. -> remove data at index = Head - 1
            
            if (Head != 0)
            {
                Head--;
                string dataToPop = Data[Head];
                Data[Head] = null;
                return dataToPop;
            }
            else
            {
                throw new StackUnderflowException("Cannot pop from an empty stack.");
            }
        }
    }   

    [System.Serializable]
    public class StackUnderflowException : System.Exception
    {
        public StackUnderflowException() { }
        public StackUnderflowException(string message) : base(message) { }
        public StackUnderflowException(string message, System.Exception inner) : base(message, inner) { }
        protected StackUnderflowException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}