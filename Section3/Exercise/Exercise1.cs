/*
Write a console-based application that prompts a user for an hourly pay rate.
While the user enter the values less than $5.65 or greater than $49.99, continue to prompt the user.
Before the program ends, display the valid pay rate.
*/

// While loop version
Console.WriteLine("Enter an hourly pay rate");
double hourlyRate = double.Parse(Console.ReadLine());

while (hourlyRate < 5.65 || hourlyRate > 49.99)
{
    Console.WriteLine("Enter an hourly pay rate");
    hourlyRate = double.Parse(Console.ReadLine());
}
Console.WriteLine("The valid pay rate is ${0}", hourlyRate);

// Do while loop version
double hourlyRate;
do
{
   Console.WriteLine("Enter an hourly rate");
   hourlyRate = double.Parse(Console.ReadLine());
} while (hourlyRate < 5.65 || hourlyRate > 49.99); {
   Console.WriteLine($"The valid pay rate is ${hourlyRate}");
}
