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

```
for i = 2 to n:                             4*(n - 2 + 1) = 4(n-1)
    tobs = A[i]                             1
    j = i - 1                               1
    
    while (tobs < A[j]) and (j > 0):        1: tobs < A[j] is always false, so only comparison is performed
        A[j+1] = A[j]                       
        j = j - 1

     A[j+1] = tobs                          1


= 4(n-1) < 5n, for n > n_0 = -4
= O(n)
```

## QuickSort