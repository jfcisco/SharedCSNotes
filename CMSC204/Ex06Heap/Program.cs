using System;

namespace Ex06Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            RunHeapTests();
        }

        // Simple test method to ensure Heap implementation is correct.
        static void RunHeapTests()
        {
            // Testing Heapify
            // Value at index = 0 is ignored.
            Heap testHeap = new Heap(3, new int[] { 0, 3, 1, 4 });

            testHeap.Heapify(1);

            Console.WriteLine($"After heapify, {testHeap.Print()}");

            int[] newArray = { 0, 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            testHeap = new Heap(10, newArray);

            Console.WriteLine($"Testing Build method with {string.Join(',', newArray)}");

            
            testHeap.Build();
            Console.WriteLine($"After building, {testHeap.Print()}.");
        }
    }
}
