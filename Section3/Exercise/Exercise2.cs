/*
Write a console-based application that sums the integers from 1 to 50
*/

int sum = 0;
Console.WriteLine("Enter an integer");
int integer = int.Parse(Console.ReadLine()); // 8

while (integer >= 1 && integer <= 50) {
  sum += integer;
  Console.WriteLine("Enter an integer");
  integer = int.Parse(Console.ReadLine()); // 10
  
}
Console.WriteLine("Sum is {0}", sum);
