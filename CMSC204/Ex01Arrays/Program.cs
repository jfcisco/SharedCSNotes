using System;

namespace Ex01Arrays
{
    class Program
    {
        /*
            Program for Array exercises:
            1.Write a procedure for reversing the elements of an array.
            2.Write a procedure for merging two sorted arrays into one.
            3.Formulate an algorithm for inserting a new element x into a sorted array A of size n.
            4.Write a procedure for finding the minimum in an array and deleting it from the array.
        */

        static void Main(string[] args)
        {
            var testInts = new int[] { 1, 2, 3, 4, 5, 9 };
            Console.WriteLine($"The original array: {string.Join(',', testInts)}");

            // Testing #1
            var reversedTestInts = Reverse(testInts);
            Console.WriteLine($"The original reversed: {string.Join(',', reversedTestInts)}");

            // Testing #2
            int[] mergedTestInts1 = { 1, 3, 4, 5, 7, 9 };
            int[] mergedTestInts2 = { 2, 4, 6, 8, 10, 11, 13, 15 };
            Console.WriteLine($"Array 1: {string.Join(',', mergedTestInts1)}");
            Console.WriteLine($"Array 2: {string.Join(',', mergedTestInts2)}");
            
            var resultingMerge = MergeSorted(mergedTestInts1, mergedTestInts2);           
            Console.WriteLine($"Merged array: {string.Join(',', resultingMerge)}");

            // Testing #3
            int insertableInt = 6;
            var insertedArray = Insert(insertableInt, testInts);
            Console.WriteLine($"Insert {insertableInt}: {string.Join(',', insertedArray)}");

            // Testing #4
            var minimumRemoved = DeleteMinimum(testInts);
            Console.WriteLine($"Original without minimum: {string.Join(',', minimumRemoved)}");
        }

        static int[] Reverse(int[] arr)
        {
            /// Reverses the elements of an array
            var reversedArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversedArray[i] = arr[arr.Length - i - 1];
            }

            return reversedArray;
        }

        static int[] MergeSorted(int[] arr1, int[] arr2)
        {
            /// Merges two sorted int arrays into one sorted array.
            /// Assumes that duplicates are not removed.
            /// Assumes that sorting is ascending (1, 2, 3, ...)
            var mergedArray = new int[arr1.Length + arr2.Length];
            int ctr1 = 0;
            int ctr2 = 0;
            int ctrMerged = 0;

            while ((ctr1 <= arr1.Length - 1) & (ctr2 <= arr2.Length - 1))
            {
                if (arr1[ctr1] <= arr2[ctr2])
                {
                    mergedArray[ctrMerged] = arr1[ctr1];
                    ctr1++;
                }
                else
                {
                    mergedArray[ctrMerged] = arr2[ctr2];
                    ctr2++;
                }

                ctrMerged++; // Assumes that every iteration inserts an element
            }
            
            // Append the rest of the array not covered earlier
            if (ctr1 > arr1.Length - 1)
            {
                for (int i = ctr2; i < arr2.Length; i++)
                {
                    mergedArray[ctrMerged] = arr2[i];
                    ctrMerged++;
                }
            }
            else
            {
                for (int i = ctr1; i < arr1.Length; i++)
                {
                    mergedArray[ctrMerged] = arr1[i];
                    ctrMerged++;
                }
            }

            return mergedArray;
        }

        static int[] Insert(int x, int[] arrA)
        {
            /// Algorithm for inserting a new element x into a sorted array A of size n.
            /// Assumes sorting is ascending

            int[] arrX = { x };
            return MergeSorted(arrX, arrA);
        }

        static int[] DeleteMinimum(int[] arr)
        {
            /// Returns a new array with its minimum value deleted
            
            // Assume arr[0] is the minimum, initially
            int minIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }

            int[] noMinimum = new int[arr.Length - 1];
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == minIndex)
                {
                    continue;
                }
                else if (i < minIndex)
                {
                    noMinimum[i] = arr[i];
                }
                else
                {
                    noMinimum[i - 1] = arr[i];
                }
            }

            return noMinimum;
        }
    }
}
