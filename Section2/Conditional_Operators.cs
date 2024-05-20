// Conditional or ternary operator (?) is a faster way of running short if statements

int x = 5;
int y = 6;

// (Condition) ? a : b
int biggestNumber = x > y ? x : y;
Console.WriteLine(biggestNumber);

Console.WriteLine("Enter 0 or 1");
int checkLight = int.Parse(Console.ReadLine());
Console.WriteLine((checkLight < 1) ? "Light is OFF" : "Light is ON");

// ! is the NOT operator which negates the value or expression put before it
bool knowsSQL = true;
Console.WriteLine(!knowsSQL ? "Does not know SQL" : "Knows SQL");

// Example of NOT operator in if/else statement
bool knowsDocker = false;
if (!knowsDocker) {
Console.WriteLine("Does not know Docker");
} else {
Console.WriteLine("Knows Docker");
}
