using System;

namespace Ex04BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new DuplicateChecker();
            int[] testData = { 0, 10, 5, 20, 10 , 5};

            foreach (int value in testData)
            {
                if (checker.IsDuplicate(value))
                {
                    Console.WriteLine($"{value} is a duplicate!");
                }
            }
        }

        static void TestDuplicateChecker()
        {

        }
        static void TestBinaryTree()
        {
            var originalBTree = new BinaryTree(10);

            originalBTree.Add(2);
            originalBTree.AddRc(20);
            originalBTree.AddRc(15);
            originalBTree.AddRc(15);
            originalBTree.AddRc(-2);
            originalBTree.AddRc(2);

            // string treeData = "";
            // originalBTree.Print(null, ref treeData);
            // Console.WriteLine(treeData);

            System.Console.WriteLine(originalBTree.PrintReverse());
        }

        static void ModifyReference(ref int i)
        {
            i = i + 1;
        }
    }
}
