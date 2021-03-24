namespace EX02LinkedLists
{
    public class LinkedList
    {
        protected Node _header { get; set; }
        protected Node _tail { get; set; }

        public LinkedList()
        {
            _header = null;
            _tail = null;
        }

        public void InsertEnd(Node newNode)
        {
            // If inserting for the first time, head = tail = newNode
            if (_header == null)
            {
                _header = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
        }

        /// <summary>Searches for a specific Node in the LinkedList whose Student matches the name.</summary>
        public Node Search(string studentName)
        {
            Node current = _header;

            while ((current != null) && (current.Data.Name != studentName))
            {
                current = current.Next;
            }

            return current;
        }

        /// <summary>Returns the Node just before the given Node.</summary>
        public Node GetPreviousNode(Node node)
        {
            Node previousNode = _header;

            if (_header == node)
            {
                previousNode = null;
            }
            else
            {
                while ((previousNode != null) && (previousNode.Next != node))
                {
                    previousNode = previousNode.Next;
                }
            }
            
            return previousNode;
        }

        /// Deletes the given Node in the linked list
        public void Delete(Node nodeToDelete)
        {
            // List is empty -> Do nothing.
            if (_header != null)
            {
                if (_header == nodeToDelete)
                {
                    // Node to remove is the only node -> reset Header and Tail to null
                    if (_header == _tail)
                    {
                        _header = null;
                        _tail = null;
                    }
                    // Removing head node -> set Header to the current Header.Next
                    else
                    {
                        _header = _header.Next;
                    }
                }
                // Removing tail node -> set Tail to Node just before the tail (need to search)
                else if (_tail == nodeToDelete)
                {
                    _tail = GetPreviousNode(_tail);
                }
                else
                {
                    // Node is either in the middle or not in the list
                    Node beforeDelete = GetPreviousNode(nodeToDelete);

                    if (beforeDelete != null)
                    {
                        beforeDelete.Next = nodeToDelete.Next;
                    }

                    // Item doesn't exist in the linkedList -> Do nothing.
                }               
            }
            
        }
    }
}
