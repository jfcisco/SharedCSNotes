# Linked List

- Linked lists have a head and tail
    - Head: First node in the list
    - Tail: Last node in the list
- Each item in the linked list has a pointer to the next item of the linked list

Delete Cases:
1. Deleting an empty linked list.
2. Deleting an only node in a linked list.
3. Deleting an item that does not exist in a linked list.

Flavors
1. Regular Linked list - tail points to null.
2. Circular Linked List - tail points to head of linked list.
3. Doubly-Linked List - each node has a reference to next and previous
    - easyier deletion?
    - binary search might be possible if operating in a sorted list
4. Singly-Linked List - each node only has a reference to next node
5. Circular Doubly-Linked List
    - Benefit: deleting an item in the middle of a linked list is accomplish-able in O(1).
    - Whereas in a singly-linked list, the program would need to traverse the entire list to get to the previous node.

Check out LinkedList class in MSDN docs to see methods and properties exposed.

Takeaway Thoughts:
1. What new knowledge about linked lists is interesting?
2. Give an example program/problem that uses a linked list. What kind of linked list is needed for this program?