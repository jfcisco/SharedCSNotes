AVL Trees (Adelson, Velski & Landis Trees)
=============================================

[Notes from Go GATE IIT video:](https://www.youtube.com/watch?v=lQp431QjrWI&t=11s)
---------------------------------

Height of the node is longest path (maximum # of edges) to a leaf.

AVL Tree: height of both child subtrees must only differ by 1 for every node. 

AVL Terminologies:
--------------------------------

### Left-Left Imbalance:
> Root node violates the AVL principle due to left child of the root node's left child.

Inserting an extra node to the left-hand side/subtree.

Remedy the situation: by doing a right rotation.
1. Root of left subtree becomes the head of the whole binary tree.
2. Original head becomes the right child of the *new* head
3. Right subtree of root of original left subtree becomes the left child of the old head node. 

In the textbook, this is a single right rotate.

## Right-Right Imbalance
> Root node violates the AVL principle due to right child of the root node's right child.

Remedy by doing a left rotation.
1. Root(Right Subtree) becomes Root(Binary Tree).
2. Old Root(Binary Tree) becomes left child of new Root(Binary Tree).
3. Left(Right Subtree) becomes right child of left child of old root.

In the textbook, this is a single left rotate.

## Right-Left Imabalance:
> Root node violates the AVL principle due to the left child of the root node's right child.

1. Consider the right subtree only, and then perform a right rotation. 
- The left child of the original root node of the right subtree will become the new root node of the right subtree.

2. Then considering the whole binary tree with the rotated right subtree, perform a left rotation.
- The right child of the original root node will become the new root node of the whole binary tree.

In the textbook, this is a double left rotate: right rotate right subtree, and then left rotate the whole subtree.

## Left-Right Imbalance
> Root node violates the AVL principle due to the right child of the root node's left child.

1. Consider the left subtree only, and then perform a left rotation.
- The right child of the original root node of the left subtree will become the new root node.

2. Considering the whole binary tree with the rotated left subtree, perform a right rotation
- The left child of the original root node will become the new root of the whole binary tree.

When inserting, the AVL tree will check the balance factor (height of left - height of right).

### Other Learnings:
* Applies recursively, meaning the violating node need not be the head node of the entire binary search tree.
* It could be the root node of the right subtree.

```    
       21
    /     \
   A       26
subtree      \
             30
             /
            28
```
Subtree with node 26 has right-left imbalance.