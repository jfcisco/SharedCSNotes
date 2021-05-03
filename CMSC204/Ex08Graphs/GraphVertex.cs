namespace Ex08Graphs
{
    // Generic implementation of a vertex in a graph
    public class GraphVertex<T>
    {
        public T Value;
        public GraphVertex(T value)
        {
            Value = value;
        }
    }
}