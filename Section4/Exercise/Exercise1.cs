/*
Write a program for a package delivery service.
The program contains an array that holds the ten zip codes to which the company delivers packages.
Prompt a user to enter a zip code and display a message indicating whether the zip code is one which the company delivers.
*/

Console.WriteLine("Enter your zip code for delivery");
int zipCode = int.Parse(Console.ReadLine());

int[] eligibleZip = { 2200, 2210, 2220, 2230, 2240, 2250, 2260, 2270, 2280, 2290 };
bool checkZip = true;
// Check every element if zipCode IS EQUAL TO eligibleZip element

for (int i = 0; i < eligibleZip.Length; i++)
{
    if (zipCode != eligibleZip[i])
    {
        checkZip = false;
    }
    else if (zipCode == eligibleZip[i])
    {
        checkZip = true;
    }

} 
    if (checkZip == true)
    {
        Console.WriteLine($"Zip code {zipCode} IS ELIGIBLE for delivery");
    }
    else
    {
        Console.WriteLine($"Zip code {zipCode} IS NOT ELIGIBLE for delivery");
    }
