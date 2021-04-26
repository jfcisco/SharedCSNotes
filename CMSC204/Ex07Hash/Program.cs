using System;
using Ex07Hash.HashTables;

namespace Ex07Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable testData = new MultiplicationHashTable(5);

            testData.Insert(1);
            testData.Insert(2);
            testData.Insert(3);

            int[] testArray = new int[] { -1, 1, 2, 3, 4 };

            foreach(int i in testArray)
            {
                Console.WriteLine($"Is {i} in the hash table? { testData.Search(i) }");
            }
        }
    }
}
