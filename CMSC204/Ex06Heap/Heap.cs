namespace Ex06Heap
{
    public class Heap
    {
        private int _size;
        private int[] _data;
        
        public Heap(int size)
        {
            _size = size;
            _data = new int[_size];
        }

        // Constructor if an input array can be provided
        public Heap(int size, int[] data)
        {
            _size = size;
            _data = data;
        }
        
        // Implements the Heapify procedure
        public void Heapify(int rootIndex)
        {
            int leftIndex = rootIndex * 2;
            int rightIndex = rootIndex * 2 + 1;
            
            int largestIndex; // Stores the index of the largest value
            
            // Check whether or not left value > root value
            if (leftIndex <= _size && _data[leftIndex] > _data[rootIndex])
            {
                largestIndex = leftIndex;
            }
            else
            {
                largestIndex = rootIndex;
            }

            if (rightIndex <= _size && _data[rightIndex] > _data[largestIndex])
            {
                largestIndex = rightIndex;
            }

            // Swap the values if the largest is not already the root
            if (largestIndex != rootIndex)
            {
                Swap(ref _data[rootIndex], ref _data[largestIndex]);

                // Recursively call heapify
                Heapify(largestIndex);

            }
        }

        // Implements the Build-Heap procedure
        public void Build()
        {
            // Since _size is an integer, C# will use integer division
            
            // Note: _size / 2 gives the index of the last internal node (or non-leaf node)
            for (int i = _size / 2; i >= 1; i--)
            {
                Heapify(i);
            }
        }

        public string Print()
        {
            // Prints a string representation of the heap
            return string.Join(',', _data);
        }

        // Swaps the values of two integer variables
        public void Swap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }
    }
}