using System;

namespace Ex05BSTAVL
{
    class Program
    {
        static void Main(string[] args)
        {
            BST searchTree = new(5);
            searchTree.Add(4);
            searchTree.Add(6);
            searchTree.Add(8);
            searchTree.Add(10);
            
            Console.WriteLine($"Maximum is {searchTree.GetMaximum()}");
            Console.WriteLine($"Minimum is {searchTree.GetMinimum()}");
        }
    }
}
