namespace Ex04BinaryTree
{
    public class BinaryTree
    {
        Node _top;

        public BinaryTree()
        {
            _top = null;
        }

        public BinaryTree(int initial)
        {
            _top = new Node(initial);
        }

        /// <summary>
        /// Adds a node to the binary tree in a non-recursive manner.
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            if (_top == null)
            {
                _top = new Node(value);
            }
            else
            {
                Node currentNode = _top;
                bool added = false;

                /*  Traverse the list to find the new value's right place.
                    According to the rules:
                        1) Left node should contain a value < parent node's value.
                        1) Right node should contain a value >= parent node's value.
                */

                do
                {
                    if (value < currentNode.Data)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = new Node(value);
                            added = true;
                        }
                        else
                        {
                            currentNode = currentNode.Left;
                        }
                    }
                    else if (value >= currentNode.Data)
                    {
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = new Node(value);
                            added = true;
                        }
                        else
                        {
                            currentNode = currentNode.Right;
                        }
                    }
                } while (!added);
            }
        }

        public void AddRc(int value)
        {
            // Recursive add method interface
            AddR(ref _top, value);
        }

        private void AddR(ref Node node, int value)
        {
            // Private recursive search for where to add the new node
            if (node == null)
            {
                node = new Node(value);
                return;
            }
            else if (value < node.Data)
            {
                // Apparently, auto-implemented properties are methods
                 // So, node.Left cannot be passed directly in a ref parameter
                Node tempNode = node.Left;
                AddR(ref tempNode, value);
                node.Left = tempNode;
            }
            else if (value >= node.Data)
            {
                Node tempNode = node.Right;
                AddR(ref tempNode, value);
                node.Right = tempNode;
            }
        }

        public void Print(Node node, ref string newString)
        {
            if (node == null)
            {
                node = _top;
            }
            
            if (node.Left != null)
            {
                Print(node.Left, ref newString);
                newString = newString + node.Data.ToString().PadLeft(3);
            }
            else
            {
                newString = newString + node.Data.ToString().PadLeft(3);
            }

            if (node.Right != null)
            {
                Print(node.Right, ref newString);
            }
        }
        
        /// <summary>
        /// Returns a string representation of the binary tree in descending order.
        /// </summary>
        /// <returns></returns>
        public string PrintReverse()
        {
            string resultString = "";
            PrintR(_top, ref resultString);
            return resultString;
        }

        private void PrintR(Node node, ref string newString)
        {
            if (node == null) { return; }

            PrintR(node.Right, ref newString);
            newString = newString + node.Data.ToString().PadLeft(3);
            PrintR(node.Left, ref newString);
        }
    }

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