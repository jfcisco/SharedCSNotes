# Questions
What is the running time for the input sequence 1, 2, 3, …, n (already sorted) of the sorting algorithms?

1. Bubble Sort 
2. Insertion Sort 
3. QuickSort 
4. MergeSort 
5. HeapSort.


# Answers
A = array of n items, already sorted from 1 to n

## Bubble Sort

```
for i = 1 to n-1:                   sum of (n - i) from i = 1 to n - 1
    for j = n to i + 1:             n - i
        if A[j] < A[j-1]:           1   
            swap(A[j], A [j-1])     

// Simplifying summation
sum of (n - i) from i = 1 to n - 1
(sum of n from i = 1 to n - 1) - (sum of i from i = 1 to n - 1)
(n-1)(n) - [(n-1)(n) / 2] = (n-1)(n) / 2 
= O(n^2)
```

## Insertion Sort