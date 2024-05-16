/*
Write a program that asks the user to enter a total amount of time in minutes only
Print to the console the same amount of time in hours and minutes
*/ 

Console.WriteLine("Enter time in minutes");
int timeInMinutes = int.Parse(Console.ReadLine());
double timeInHours = (double) timeInMinutes / 60;

Console.WriteLine("{0} minutes = {1} hours", timeInMinutes, timeInHours);
