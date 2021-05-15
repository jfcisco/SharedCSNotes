Try to get the best-, average- and worst-cases for the algorithms below:
# 1. Selection Sort
```
procedure SelectionSort(A) 
begin
    for i = n down to 2 do 
    begin
        MaxPosition = i; 
        for j = 1 to (i - 1) do 
            if A[j] > A[MaxPosition] MaxPosition = j; 
            Swap(A[i],A[MaxPosition])
    end 
end
```

## Find Best, Worst, Average-Case complexity:
```
// Assuming n = length of array
procedure SelectionSort(A) 
begin

    for i = n down to 2 do => n - 2 + 1 = n - 1 operations (n, n - 1, n - 2, ..., 2)
    begin // one iteration performs (a + b(i - 1) +c) operations => simplify to b(i - 1) + d operations (where d = a + c)
        MaxPosition = i; => a operations
        
        for j = 1 to (i - 1) do => i - 1 - 1 + 1 = b(i - 1) operations
            if A[j] > A[MaxPosition] MaxPosition = j; => b operations
            
        Swap(A[i],A[MaxPosition]) => c operations
    end 
end
```

let g(i): number of operations in an iteration of the outer loop
g(i) = b(i - 1) + d = bi - b + d = bi + e; where e = - b + d

sum of (bi + e) from i = 2 to n
= (b * sum (i) from i = 2 to n) + (n * sum (1) from i = 2 to n)
= (b * (2 + n)*(n / 2)) + n (n - 2 + 1)
= (b * (n + n^2 / 2)) + n (n - 1)
= (bn + bn^2 / 2) + n^2 - n
= (b + 2) n^2 / 2 + (b - 1)n
= O(n^2)


Total number of operations: f(n) 
= n - 1 + n - 2 + n - 3 + ... 1 
= ((1 + n - 1)n) / 2
 = n ^ 2 / 2

Worst-case (reverse sorted): f(n) = O(n^2)
Best-case (already sorted): f(n) = O(n^2)
Average-case: O(n^2) + O(n^2) / 2 = O(n^2)


# 2. Recursive Selection Sort
```
procedure SelectionSort(A,n) 
begin
    if n > 1 then 
    begin
        MaxPosition = FindMax(A,n) 
        Swap(A[n], A[MaxPosition]) 
        SelectionSort(A,n-1)
    end 
end

FindMax(A,n) 
begin 
    j = n
    for i = 1 to (n-1) do 
        if A[i] > A[j] then j = i
    return(j) 
end

```

```
let f(n): running time of recursive selection sort for an n-length array

base case: 
    f(1) = c


procedure SelectionSort(A,n) 
begin
    if n > 1 then                       =>  c
    begin
        MaxPosition = FindMax(A,n)      =>  b_1 + g(n)
        Swap(A[n], A[MaxPosition])      =>  b_2
        SelectionSort(A,n-1)            =>  f(n-1)
    end 
end

let g(n): running time of FindMax for an n-length array

g(n) = b_1 + (b_3)(n-1)

FindMax(A,n) 
begin 
    j = n                               => b_1
    for i = 1 to (n-1) do               => n-1 times
        if A[i] > A[j] then j = i       => b_3
    return(j) 
end

Constants:
-----------
b_1: Cost of Assignment
b_2: Cost of Swap
b_3: Cost of "if A[i] > A[j] then j = i"
c: cost of comparing
d: b_1 + b_1 + b_2 + c - b_3

Building f(n)
---------------
f(n) = c + b_1 + g(n) + b_2 + f(n-1)                            // Initial formulation
f(n) = c + b_1 + b_1 + (b_3)(n-1) + b_2  + f(n-1)               // Expand g(n)
f(n) = d + b*n + f(n-1)                                         // Simplify constants


```