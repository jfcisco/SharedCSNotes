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
            _PrintReverse(_top, ref resultString);
            return resultString;
        }

        /// <summary>
        /// Recursive implementation for PrintReverse()
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newString"></param>
        private void _PrintReverse(Node node, ref string newString)
        {
            if (node == null) { return; }

            _PrintReverse(node.Right, ref newString);
            newString = newString + node.Data.ToString().PadLeft(3);
            _PrintReverse(node.Left, ref newString);
        }

        /// <summary>
        /// Adds value to the binary tree only if the value has not been added before.
        /// </summary>
        /// <param name="toAdd"></param>
        /// <returns>True only if value is added, and false otherwise</returns>
        public bool AddUnique(int value)
        {
            return _AddUnique(ref _top, value);
        }

        private bool _AddUnique(ref Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
                return true;
            }
            else if (value == node.Data)
            {
                // Cannot add as value is already in the list.
                return false;
            }
            else if (value < node.Data)
            {
                Node tempNode = node.Left;
                bool added = _AddUnique(ref tempNode, value); // hold result of operation to be returned later
                node.Left = tempNode;
                return added;

            }
            else // value > node.Data
            {
                Node tempNode = node.Right;
                bool added = _AddUnique(ref tempNode, value);
                node.Right = tempNode;
                return added;
            }
        }
    }
}