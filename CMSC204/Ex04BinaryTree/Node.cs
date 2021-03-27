namespace Ex04BinaryTree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int initial)
        {
            Data = initial;
            Left = null;
            Right = null;
        }
    }
}