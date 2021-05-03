using System;

namespace Ex08Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            MatrixGraph letters = new MatrixGraph();
            
            letters.AddVertex('A');
            letters.AddVertex('B');
            letters.AddVertex('C');

            letters.AddEdge('A', 'B');
            letters.AddEdge('A', 'C');

            Console.WriteLine(letters);
        }
    }
}
