using System;

namespace Ex08Graphs
{
    /// <summary>
    /// Implements the Graph data structure using an adjacency matrix
    /// </summary>
    public class AdjacencyMatrixGraph
    {
        // Assumptions: Graph is unweighted and undirected. 

        private int Capacity; // Total number of supported nodes in the graph
        private int Size; // Number of nodes in the graph
        private GraphVertex[] Vertices;
        private int[,] AdjacencyMatrix;
        
        // Instantiate an empty graph
        public AdjacencyMatrixGraph()
        {
            Size = 0;
            Capacity = 0;
            Vertices = new GraphVertex[0];
            AdjacencyMatrix = new int[0, 0];
        }

        public AdjacencyMatrixGraph(int size, int[,] adjacencyMatrix)
        {
            Size = size;
            Capacity = 0;
            Vertices = new GraphVertex[Size];
            AdjacencyMatrix = adjacencyMatrix;
        }

        // Adds a vertex to the graph containing the given data
        public void AddVertex(char data)
        {
            // Resize graph if no space exists anymore
            if (Size == Capacity)
            {
                int newCapacity = (Capacity != 0) ? Capacity * 2 : 1; 
                Resize(newCapacity);
            }

            Vertices[Size] = new GraphVertex(data);
            Size += 1;
        }

        // Resizes the MatrixGraph to a specified new capacity
        // Assumption: Vertex indices are consistent with adjacency matrix
        private void Resize(int newCapacity)
        {
            Array.Resize<GraphVertex>(ref Vertices, newCapacity);

            int[,] newMatrix = new int[newCapacity, newCapacity];

            if (AdjacencyMatrix != null)
            {
                // Copy elements from current matrix to new matrix
                for (var i = 0; i < Capacity; i++)
                {
                    for (var j = 0; j < Capacity; j++)
                    {
                        newMatrix[i, j] = AdjacencyMatrix[i, j];
                    }
                }
            }
        
            // Replace old matrix with new matrix
            Capacity = newCapacity;
            AdjacencyMatrix = newMatrix;
        }

        // Returns a representation of the graph as an adjancency matrix
        // Vertices are displayed as headers on the top and left side
        public override string ToString()
        {
            string result = string.Empty;
            
            // Write out top header
            result += " ";
            for (var i = 0; i < Size; i++)
            {
                result += Vertices[i].Value.ToString().PadLeft(3);
            }
            result += "\n";

            // Write out each row
            for (var i = 0; i < Size; i++)
            {
                result += Vertices[i].Value;

                for (var j = 0; j < Size; j++)
                {
                    result += AdjacencyMatrix[i, j].ToString().PadLeft(3);
                }

                result += "\n";
            }

            return result;
        }

        // Adds an edge between a vertex at index x & a vertex at index y.
        public void AddEdge(char x, char y)
        {
            if (!IsInExistingVertex(x) || !IsInExistingVertex(y))
            {
                throw new Exception("Cannot find x or y");
            }

            int xIndex = GetIndex(x);
            int yIndex = GetIndex(y);

            AdjacencyMatrix[xIndex, yIndex] = 1;
            AdjacencyMatrix[yIndex, xIndex] = 1;
        }
        
        private int GetIndex(char searchValue)
        {
            int index = 0;

            for (; index < Size; index++)
            {
                if (Vertices[index].Value == searchValue)
                {
                    return index;
                }
            }

            return -1;
        }

        // Checks if the given char is in an existing vertex
        private bool IsInExistingVertex(char testValue)
        {
            for (int i = 0; i < Size; i++)
            {
                if (Vertices[i].Value == testValue)
                {
                    return true;
                }
            }

            return false;
        }
    }
}