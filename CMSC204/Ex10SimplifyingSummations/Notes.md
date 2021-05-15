# Recurrence

- Defined as an equation or inequality that describes a function in terms of its value on smaller inputs.

Example of a recurrence:

Define a fibonacci sequence as the ff:
let f(n) be the n-th term of a fibonacci sequence
f(0) = 0
f(1) = 1
therefore, f(n) = f(n-1) + f(n-2)

0, 1, 1, 2, 3, 5, 8, ...

# Methods for Simplifying Recurrences

## Substitution Method

- How can we find the closed-form, and possibly the (running time) complexity of a method whose running time is defined by a recurrence?
### Guessing Bounds
- Guess a bound [e.g. T(n) <= O(n log n)] and prove by induction

### Building and Expansion (Iteration Method) / Iterative Substitution
[Iterative Substitution (Plug and Chug)](https://www.youtube.com/watch?v=Ob8SM0fz6p0)
- Substitution method seems to be about manually expanding a recurrence determining T(n) using the T(n/2) or T(n-1) or whatever recursive definition it has.
- A solution building thingo has to be set aside on one side of the paper, and another half for the scratch paper for expanding the equation.
- Expand the recursion (one layer deep) and then substitute it back into the original equation. Repeat until the base case is reached.

### Iteration Method
[Solved Recurrence Tree Method](https://www.youtube.com/watch?v=sLNPd_nPGIc)
- No idea what I watched lol
- Am I right in saying that at the level of T(n/2), branches from 4n are because of the 2T(n/2) + 4n of the function definition?

