using System;

namespace Ex01Arrays
{
    /// <summary>
    /// Array implementation that does not use the framework-provided Array class.
    /// </summary>
    public class Array
    {
        public int Length; // Capacity of array
        public int Size; // No. of elements added to the array
        public int[] Data { get; set; }
        
        public Array(int length)
        {
            Length = length;
            Data = new int[length];
            Size = 0;
        }

        public void Add(int value)
        {
            // Size will always be one ahead of empty index
            Data[Size] = value;
            Size++;
        }

        public void RemoveAt(int index)
        {
            // Removes the data at the given index
            // Assume that given index is within bounds
            /*
                for i = index to second last element:
                    Data[i] = Data[i + 1];
                
                set last element to null
                decrement size
            */

            if (index < 0 || index >= Size)
            {
                throw new Exception("Index out of bounds");
            }

            for (int i = index; i < Size - 1; i++)
            {
                Data[i] = Data[i + 1];
            }

            Data[Size - 1] = 0; // "Erase" data of last element
            Size--;
        }

        public string PrintContents()
        {
            string resultString = "";

            for (var i = 0; i < Size ; i++)
            {
                resultString += Data[i].ToString().PadLeft(5);
            }

            return resultString;
        }
    }
}