using System;
// TODO: Remove dependency on System.Collections.Generic. Better to use own Stack and Queue implementation
using System.Collections.Generic;

namespace Ex08Graphs
{
    /// <summary>
    /// Implements the Graph data structure using an adjacency matrix
    /// </summary>
    public class AdjacencyMatrixGraph<T> : Graph<T>
    {
        private int Order; // Number of vertices in the graph

        // Assumptions: Graph is unweighted and undirected. 
        public T[] Vertices { get; private set; }

        // TODO: Add validation in case the adjacency matrix is of the wrong dimension.
        public byte[][] AdjacencyMatrix { get; set; }

        /// <summary>
        /// Instantiates an adjacency matrix graph with a given array of vertex values
        /// </summary>
        /// <param name="vertexValues">Array of vertex values</param>
        public AdjacencyMatrixGraph(T[] vertexValues)
        {
            Order = vertexValues.Length;

            Vertices = new T[Order];
            for (int i = 0; i < Order; i++)
            {
                Vertices[i] = vertexValues[i];
            }

            // Initialize Adjacency Matrix
            AdjacencyMatrix = new byte[Order][];

            for (int i = 0; i < Order; i++)
            {
                AdjacencyMatrix[i] = new byte[Order];
            }
        }

        public override T[] PerformDepthFirstTraversal()
        {
            // Keeps track of the order the indices were visited
            int[] indicesOfVisited = new int[Order]; // visited indices
            int countOfVisitedVertices = 0;

            // Mirrors the Vertices array: visited[i] = true if Vertices[i] is already visited
            bool[] visited = new bool[Order];

            // Keep vertex indices in the stack
            Stack<int> stack = new Stack<int>();

            // Push the first vertex to the stack
            stack.Push(0);
            
            while (stack.Count > 0)
            {
                // Get index of the vertex being visited 
                int currentIndex = stack.Pop();

                if (!visited[currentIndex])
                {
                    // Count vertex as visited
                    indicesOfVisited[countOfVisitedVertices] = currentIndex;
                    countOfVisitedVertices++;
                    visited[currentIndex] = true;

                    // Push unvisited vertices that are adjacent to currentVertex to the stack.
                    for (int i = 0; i < Order; i++)
                    {
                        bool isAdjacentToCurrentVertex = AdjacencyMatrix[currentIndex][i] == 1;
                        if (isAdjacentToCurrentVertex && !visited[i])
                        {
                            stack.Push(i);
                        }
                    }
                }
            }

            // Map visited indices to their values
            T[] verticesVisited = new T[Order];
            
            for (int i = 0; i < Order; i++)
            {
                verticesVisited[i] = Vertices[indicesOfVisited[i]];
            }

            return verticesVisited;
        }

        public override T[] PerformBreadthFirstTraversal()
        {
            int[] indicesOfVisited = new int[Order];
            int countOfVisitedVertices = 0;
            bool[] visited = new bool[Order];

            // Keep a queue for perfomring BFS traversal
            Queue<int> queue = new Queue<int>();

            // Push the starting node to the queue
            queue.Enqueue(0);

            while(queue.Count > 0)
            {
                int currentIndex = queue.Dequeue();

                if (!visited[currentIndex])
                {
                    // Visit the vertex
                    indicesOfVisited[countOfVisitedVertices] = currentIndex;
                    countOfVisitedVertices++;
                    visited[currentIndex] = true;

                    // Enqueue all adjacent and unvisited vertices
                    for (var i = 0; i < Order; i++)
                    {
                        bool isAdjacentToCurrentVertex = AdjacencyMatrix[currentIndex][i] == 1;

                        if (isAdjacentToCurrentVertex && !visited[i])
                        {
                            queue.Enqueue(i);
                        }
                    }
                }
            }

            T[] verticesVisited = new T[Order];

            for (var i = 0; i < Order; i++)
            {
                verticesVisited[i] = Vertices[indicesOfVisited[i]];
            }

            return verticesVisited;
        }

        public override bool SearchBreadthFirst(T value)
        {
            throw new NotImplementedException();
        }

        public override bool SearchDepthFirst(T value)
        {
            throw new NotImplementedException();
        }
    }
}