namespace EX02LinkedLists
{
    public class DoublyLinkedList
    {
        private DoublyLinkedListNode _head;

        // Task: Implement Search, Add, Delete

        public DoublyLinkedListNode Search(int value)
        {
            if (_head == null) { return null; } // Empty list
            
            DoublyLinkedListNode current = _head;

            while (current != null && current.Value != value)
            {
                current = current.Right;
            }

            if (current.Value == value)
            {
                return current;
            }
            else
            {
                return null; // node with matching value cannot be found
            }
        }

        /// <summary>
        /// Inserts a node with the given value to the right of Node refNode.
        /// </summary>
        /// <param name="refNode"></param>
        public void InsertRight(DoublyLinkedListNode refNode, int newValue)
        {
            // If list is empty (refNode is disregarded), insert newValue as first element of list.
            if (_head == null)
            {
                _head = new DoublyLinkedListNode(newValue);
            }
            else
            {
                var newNode = new DoublyLinkedListNode(newValue);
                
                // In case refNode is the list's last node
                if (refNode.Right != null)
                {
                    DoublyLinkedListNode after = refNode.Right;
                    newNode.Right = after;
                    after.Left = newNode;
                }

                refNode.Right = newNode;
                newNode.Left = refNode; 
            }
        }
    }

    public class DoublyLinkedListNode
    {
        public int Value { get; set; }
        public DoublyLinkedListNode Left { get; set; }
        public DoublyLinkedListNode Right { get; set; }

        public DoublyLinkedListNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}