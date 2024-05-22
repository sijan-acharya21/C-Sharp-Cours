/*
Write a console-based application that prompts a user for an hourly pay rate.
While the user enter the values less than $5.65 or greater than $49.99, continue to prompt the user.
Before the program ends, display the valid pay rate.
*/

Console.WriteLine("Enter an hourly pay rate");
double hourlyRate = int.Parse(Console.ReadLine());

while (!(hourlyRate < 5.65 || hourlyRate > 49.99)) {
  Console.WriteLine("Enter an hourly pay rate");
}
Console.WriteLine("The valid pay rate is ${0}", hourlyRate);
