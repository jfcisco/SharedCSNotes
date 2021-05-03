namespace Ex08Graphs
{
    // Describes the APIs for the Graph data structure
    public abstract class Graph<T>
    {
        public abstract GraphVertex<T>[] PerformDepthFirstTraversal();

        public abstract GraphVertex<T>[] PerformBreadthFirstTraversal();

        public abstract bool SearchDepthFirst();

        public abstract bool SearchBreadthFirst();
        
    }
}