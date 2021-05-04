namespace Ex08Graphs
{
    // Describes the APIs for the Graph data structure
    public abstract class Graph<T>
    {
        public abstract T[] PerformDepthFirstTraversal();

        public abstract T[] PerformBreadthFirstTraversal();

        public abstract bool SearchDepthFirst(T value);

        public abstract bool SearchBreadthFirst(T value);
        
    }
}