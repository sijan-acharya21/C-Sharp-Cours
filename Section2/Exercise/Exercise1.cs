/*
Write a program that prompts the user for an hourly pay rate. 
If the value entered is less than $7.50 or greater than $49.00, display an error message, otherwise display a message indicating that the rate is okay
*/

Console.WriteLine("Enter hourly pay rate");
double hourlyRate = double.Parse(Console.ReadLine());

// Using ternary operator
Console.WriteLine(hourlyRate < 7.50 || hourlyRate > 49.00 ? "Hourly rate is less than $7.50 or greater than $49.00" : "The rate is okay");

// Using if / else statement
if (hourlyRate < 7.50 || hourlyRate > 49.00) {
  Console.WriteLine("Hourly rate is less than $7.50 or greater than $49.00");
} else {
  Console.WriteLine("The rate is okay");
