// Arithmetic operators
double myDouble = 45 / 2;
Console.WriteLine(myDouble); // Result comes as an integer

myDouble = 45.0 / 2;
Console.WriteLine(myDouble); // Result comes as a double


// Modulus operator (%) finds the remainder
double remainder = 5 % 4;
Console.WriteLine(remainder); // Remainder is 1 because f4 * 1 = 4, 1 left

// Operator precedence is % , * , / from left to right and then comes  + and - going left to right
int operation = 2 + 4 * 3; // 14 => Multiplication is higher precedence (4 * 3) and then add 2

// Parentheses can change the operation
int operation2 = (2 + 4) * 3; // 18 => Parentheses is highest in precedence (6) * 3

// Different ways to incrementing variables
int x = 5;
x = x + 1; // First way of incrementing
x += 1; // Second way of incrementing

// Incrementing variables using operator as prefix and postfix

// Prefix operator
int c = 5;
Console.WriteLine(c);
int d = c++;
Console.WriteLine("Value of c: {0} and value of d: {1}", c, d);

// Postfix operator
int a = 10;
Console.WriteLine(a);
int b = a++;
Console.WriteLine("Value of a: {0} and value of b: {1}", a, b); // a = 11, b = 10
