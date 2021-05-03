using System;

namespace Ex08Graphs
{
    /// <summary>
    /// Implements the Graph data structure using an adjacency matrix
    /// </summary>
    public class AdjacencyMatrixGraph<T> : Graph<T>
    {
        // Assumptions: Graph is unweighted and undirected. 
        private GraphVertex<T>[] Vertices { get; set;  }

        // TODO: Add validation in case the adjacency matrix is of the wrong dimension.
        private byte[,] AdjacencyMatrix { get; set; }

        /// <summary>
        /// Instantiates an adjacency matrix graph with a given array of vertex values
        /// </summary>
        /// <param name="vertexValues">Array of vertex values</param>
        public AdjacencyMatrixGraph(T[] vertexValues)
        {
            int size = Vertices.Length;

            for (int i = 0; i < size; i++)
            {
                Vertices[i] = new GraphVertex<T>(vertexValues[i]);
            }

            AdjacencyMatrix = new byte[size, size];
        }

        public override GraphVertex<T>[] PerformBreadthFirstTraversal()
        {
            throw new NotImplementedException();
        }

        public override GraphVertex<T>[] PerformDepthFirstTraversal()
        {
            throw new NotImplementedException();
        }

        public override bool SearchBreadthFirst()
        {
            throw new NotImplementedException();
        }

        public override bool SearchDepthFirst()
        {
            throw new NotImplementedException();
        }
    }
}