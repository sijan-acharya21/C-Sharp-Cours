/*
Write a program that asks the user to enter a total amount of time in minutes only
Print to the console the same amount of time in hours and minutes
*/ 

Console.WriteLine("Enter time in minutes");
int timeInMinutes = int.Parse(Console.ReadLine());
double timeInHours = (double) timeInMinutes / 60;

// Another way to output solution
// Console.WriteLine("{0} minutes = {1} hours", timeInMinutes, timeInHours);

// Formating decimal places - Use {0:0.00} for 2 decimal places, {0.000} for 3 decimal places ...
Console.WriteLine("{0} minutes = {1:0.00} hours", timeInMinutes, timeInHours);

// CORRECT SOLUTION
// MISTAKE - Did not read the question carefully in the second line : "amount of time in hours and minutes"
Console.WriteLine("Enter time in minutes");
int timeInMinutes = int.Parse(Console.ReadLine());
int timeInHours = timeInMinutes / 60;
int remainder = timeInMinutes % 60;
Console.WriteLine("{0} minutes = {1} hours and {2} minutes", timeInMinutes, timeInHours, remainder);
