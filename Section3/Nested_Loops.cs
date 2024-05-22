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
