// Build a simple calculator. Read in two integers from end user and add them together. Print the results in a nice output statement

Console.WriteLine("Enter your first integer");
int integer1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your second integer");
int integer2 = int.Parse(Console.ReadLine());
int sum = integer1 + integer2;

Console.WriteLine($"{integer1} and {integer2} add up to {sum}");
