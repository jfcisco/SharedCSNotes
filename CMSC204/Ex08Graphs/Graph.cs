namespace Ex08Graphs
{
    // Describes the APIs for the Graph data structure
    public abstract class Graph
    {
        public abstract GraphVertex[] PerformDepthFirstTraversal();

        public abstract GraphVertex[] PerformBreadthFirstTraversal();

        public abstract bool SearchDepthFirst();

        public abstract bool SearchBreadthFirst();
        
    }
}