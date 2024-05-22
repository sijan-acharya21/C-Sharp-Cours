// Nested means one component inside another component
// A nested loop is a loop within another loop
for (int i = 0; i < 10; i++) {
  Console.Write("*");
}

// Creating a square
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.Write("*");
}
Console.WriteLine();

// Creating the square above using nested loops
for (int j = 0; j < 6; j++) {
  for (int i = 0; i < 10; i++) {
    Console.Write("*");
  }
  Console.WriteLine();
}

// Creating a square based on user input size
Console.WriteLine("Enter the size of the square");
int size = int.Parse(Console.ReadLine());

for (int j = 0; j < size; j++) {
  for (int k = 0; k < size; k++) {
    Console.Write("{0,-2}", "*"); // -2 inside curly braces means 2 spaces to the left
  } 
  Console.WriteLine(); // Cursor goes to a new line after completing everything above
}
