using Xunit;

namespace Ex08Graphs.Tests
{
    public class AdjacencyMatrixGraphTests
    {
        [Fact]
        public void CanInstantiateAdjacencyMatrixGraph()
        {
            int[] vertices = { 1, 2, 3 };
            AdjacencyMatrixGraph<int> graph = new AdjacencyMatrixGraph<int>(vertices);

            Assert.NotNull(graph);
        }

        [Fact]
        public void DepthFirstTraversalIsCorrect()
        {
            // Use example graph in the book
            int[] vertices = { 1, 2, 3, 4, 5, 6 };

            // Manually setup adjacency matrix 
            byte[][] adjacencyMatrix = 
            {           //   1  2  3  4  5  6
                new byte[] { 0, 1, 1, 0, 0, 0 },
                new byte[] { 1, 0, 1, 1, 0, 0 },
                new byte[] { 1, 1, 0, 0, 1, 0 },
                new byte[] { 0, 1, 0, 0, 1, 1 },
                new byte[] { 0, 0, 1, 1, 0, 1 },
                new byte[] { 0, 0, 0, 1, 1, 0 }
            };

            AdjacencyMatrixGraph<int> graph = new AdjacencyMatrixGraph<int>(vertices) { AdjacencyMatrix = adjacencyMatrix };

            int[] resultOfDFSTraversal = graph.PerformDepthFirstTraversal();

            Assert.Equal(new int[] { 1, 3, 5, 6, 4, 2 }, resultOfDFSTraversal);
        }
    }
}