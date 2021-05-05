using System;

namespace Ex08Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            char[] vertices = { 'A', 'B', 'C' };
            AdjacencyMatrixGraph<char> letters = new AdjacencyMatrixGraph<char>(vertices);
            
            Console.WriteLine(letters);
        }
    }
}
