1. Differentiate the representations used to represent the different types of data (character, integer, real, etc.);

Integers are represented as a number of a specific base. In the textbook, three base systems were covered: binary, decimal, and hexadecimal. In the binary system, the 2's complement is used to differentiate positive and negative numbers. 

Real numbers are represented by three integers forming the expression (-1) ^ S x C x 2 ^ E, where S, C and E are called the sign bit, coefficient and exponent, respectively. It's similar to how scientific notation is used for decimal numbers (e.g. 123,456.78 is 1.2345678 x 10 ^ 5 in scientific notation). The textbook mentions that two 16-bit words are allocated for a real number where 1 bit is used for the sign bit, 8 bits are for the exponent, and 23 bits are for the digits of the coefficient after the first significant digit (which is always 1 after normalization).

Characters are represented as an unsigned integer but with a predefined mapping of numbers to characters. For example, 97_10 may correspond to the character a. The book mentions the ASCII character set as an example of this mapping. I would assume that text, being a sequence of characters, are represented as an array of unsigned integers.

2. Explain how a program is represented in the memory of the computer;

A program is a sequence of instructions to a computer. These instructions are encoded in bits and stored in a location in memory reserved for programs. Each instruction consists of an operation code which specifies what must be done, and zero or more operands that the computer may execute the specified operation on.

---

I noticed that the textbook's method for representing real numbers in binary is similar to the floating point format for binary numbers prescribed by the IEEE 754 standard but differs on two points: 

a) the textbook considers the hidden bit of the coefficient to take the value 0.5 (2 ^ -1), while IEEE 754 considers the hidden bit to mean 1 (2 ^ 0); and 

b) the textbook makes the exponent biased by complementing the left bit or adding 2 ^ n while IEEE 754 makes the exponent biased by adding 2 ^ n-1 - 1, where n is the number of bits for the exponent.

I mentioned IEEE 754 because it seems to be the most prevalent way for representing real numbers as binary (even Python and C# uses it for the float data type), and there are more resources for it online especially for learning to convert real numbers from decimal to binary representation and vice versa :)

I just now wonder why the authors preferred an alternative to IEEE 754.