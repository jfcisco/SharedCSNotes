using System;

namespace Ex03StacksQueues
{
    public class ArrayStack<T>
    {
        private int Size;
        private T[] Data;
        private int Head;

        public ArrayStack()
        {
            Size = 1;
            Data = new T[Size];
            Head = 0;
        }

        public int Count => Head;

        public void Push(T value)
        {
            if (Head < Size)
            {
                Data[Head] = value;
                Head++;
            }
            else
            {
                // No more space in the stack
                int newSize = Size * 2;
                Data = GrowArray(newSize);
                Size = newSize;
                Push(value);
            }
        }

        // Returns the Data array but bigger
        private T[] GrowArray(int newSize)
        {
            T[] newArray = new T[newSize];

            // Copy Data elements to bigger array
            for (int i = 0; i < Size; i++)
            {
                newArray[i] = Data[i];
            }

            return newArray;
        }

        public T Pop()
        {
            if (Head > 0)
            {
                Head--;
                T poppedValue = Data[Head];
                Data[Head] = default;
                return poppedValue;
            }
            else
            {
                throw new Exception("Stack underflow error!");
            }
        }
    }
}