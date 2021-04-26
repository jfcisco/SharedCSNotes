using System;

namespace Ex07Hash.HashTables
{
    public abstract class HashTable
    {
        protected int[] Data;
        protected int Size;

        // Declares a new HashTable of the given size.
        public HashTable(int size)
        {
            Size = size;
            Data = new int[Size];
        }

        public void Insert(int value)
        {
            // Insert only if there is no spot.
            if (Data[Hash(value)] == default(int))
            {
                Data[Hash(value)] = value;                
            }
            else
            {
                throw new Exception("Collision!");
            }
        }

        public bool Search(int value)
        {
            return Data[Hash(value)] == value;
        }

        public void Delete(int value)
        {
            Data[Hash(value)] = default(int);
        }

        protected abstract int Hash(int value);
    }
}