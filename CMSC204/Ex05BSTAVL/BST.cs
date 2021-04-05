namespace Ex05BSTAVL
{
    public class BST
    {
        private Node _head;

        public BST()
        {
            _head = null;    
        }

        public BST(int initialValue)
        {
            var initialNode = new Node(initialValue)
            {
                Left = null,
                Right = null
            };

            _head = initialNode;
        }

        public void Add(int value)
        {
            // Recursive add method interface
            Add(ref _head, value);
        }

        private void Add(ref Node node, int value)
        {
            // Private recursive search for where to add the new node
            if (node == null)
            {
                node = new Node(value);
                return;
            }
            else if (value < node.Value)
            {
                // Apparently, auto-implemented properties are methods
                // So, node.Left cannot be passed directly in a ref parameter
                Node tempNode = node.Left;
                Add(ref tempNode, value);
                node.Left = tempNode;
            }
            else if (value >= node.Value)
            {
                Node tempNode = node.Right;
                Add(ref tempNode, value);
                node.Right = tempNode;
            }
        }

        private class Node
        {
            public int Value;
            public Node Left;
            public Node Right;

            public Node(int initialValue)
            {
                Value = initialValue;
                Left = null;
                Right = null;
            }
        }
    }
}