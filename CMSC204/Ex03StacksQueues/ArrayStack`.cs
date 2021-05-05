using System;

namespace Ex03StacksQueues
{
    public class ArrayStack<T>
    {
        private int Size;
        private T[] Data;
        private int Head;

        public ArrayStack(int size)
        {
            Size = size;
            Data = new T[size];
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
                throw new Exception("Stack overflow error!");
            }
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