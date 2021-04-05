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
            // Instatiate new node for the head.
            // Parent = null since it is the head node.
            var initialNode = new Node(initialValue, null)
            {
                Left = null,
                Right = null
            };

            _head = initialNode;
        }

        public void Add(int value)
        {
            /*
                Cases to consider:
                1. Insert into an empty tree.
                2. Insert into a non-empty tree.
            */
            Add(ref _head, value);
        }

        private void Add(ref Node node, int value)
        {
            // Private recursive search for where to add the new node
            if (node == null)
            {
                // Base case for recursion
                node = new Node(value, null);
                return;
            }
            else if (value < node.Value)
            {
                // Apparently, auto-implemented properties are methods
                // So, node.Left cannot be passed directly in a ref parameter
                Node tempNode = node.Left;
                Add(ref tempNode, value);
                    
                tempNode.Parent = node;     // Update new node's parent pointer
                node.Left = tempNode;
            }
            else if (value >= node.Value)
            {
                Node tempNode = node.Right;
                Add(ref tempNode, value);

                tempNode.Parent = node;     // Update new node's parent pointer
                node.Right = tempNode;
            }
        }

        public int GetMinimum()
        {
            // Get the left-most node
            Node currentNode = _head;
            
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }

            return currentNode.Value;
        }

        public int GetMaximum()
        {
            // Get the right-most node
            Node currentNode = _head;

            while (currentNode.Right != null)
            {
                currentNode = currentNode.Right;
            }

            return currentNode.Value;
            
        }

        private class Node
        {
            public int Value;
            public Node Parent;
            public Node Left;
            public Node Right;

            public Node(int initialValue, Node parent)
            {
                Value = initialValue;
                Parent = parent;
                Left = null;
                Right = null;
            }
        }
    }
}