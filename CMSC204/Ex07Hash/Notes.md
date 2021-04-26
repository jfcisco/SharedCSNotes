# Hashing

Taking searching from O(n) to O(log n) to O(1)

## Two parts:
1. Hash Table (Array)
> Insert the values that need to be inserted. 

2. Mapping Function or Hash Function
> Input space to the integer space: Define the indices of the array.

## Operations
1. Insertion
    1. Using the Hash Function and Value (to insert) as input, compute the index of the value in the array.
    2. To insert, perform array[hash_index] = value

2. Search/Contains
    1. Similar to insertion, computed hash index is checked if it contains the value tested.

3. Deletion
    1. Search for the item in the array.
    2. Delete by searching for the value, and then "emptying" the value's spot in the has table. 
    3. If it is not in the array, return an error message.

## Hash Collision
1. Hash function returns a similar output value for two or more different input values.
2. They can overwrite each other if not taken care of.
3. Solution A: Very good hash function that has no collision
4. Solution B: Linked list (read up on chaining)

## Hash Functions
1. Must satisfy (approximately) the assumption of simple uniform hashing (SUH)
2. Each key is equally likely to has to any of the m slots (a la uniform distribution).

### Example Hash Functions: 

Given a value k, and a hash table with m members,
1. Division method: H(k) = k % m
2. Multiplication method: H(k) = floor(fractional_part(k * a) * m), where 0 < a < 1
    1. Extract fractional part of k * a and multiply the fractional by m.
    2. What is the value of a? a should be (sqrt(5) - 1 ) / 2
3. Universal Hashing
    1. Guards against adversaries, random hash functions
4. Direct Access Table
    1. Works for small universal set of keys

Use linked list when chaining keys to insert successfully in spite of a hash collision.

### Takeaway Thoughts: 
1. What new knowledge about hashing is most interesting for you?
    1. I am surprised that this lesson also had a mini-review of probability theory. I appreciate how the different hashing methods has their own way of meeting the SUH assumption.
2. How will you apply hashing?
    1. Considering the reference to adversaries in the module and what everyone else had shared in the forum so far, I think hashing has applications in cryptography so if I do some work related to information security this will come in handy.

Question:
1. If we have a hash function that produces no collision, won't that be just as bad as direct addressing? In this case, each element will map to a single slot so a hash table that can support the hash function must allocate enough memory?