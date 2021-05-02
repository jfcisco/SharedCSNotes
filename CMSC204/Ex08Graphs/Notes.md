# Graph Data Structure

## Exercises
0. Sketch out a graph
1. Write the adjacency list representation
2. Write the adjacency matrix representation
3. Write an algorithm for breadth-first search
4. Write an algorithm for depth-first search

## Notes from Playlist
1. Graphs can be represented by using the right data structure for the vertices and edges
    1. For the vertices, either an array or a hash table (for faster searching)
    2. For the edges, we can use a 2D array or a matrix:
        1. Each cell in the matrix can take a boolean value (if edges have no weights) or an integer value for weighted edges.
        2. In the latter, a convention is used to represent absent edges.
        