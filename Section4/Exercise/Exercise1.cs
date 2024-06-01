/*
Write a program for a package delivery service.
The program contains an array that holds the ten zip codes to which the company delivers packages.
Prompt a user to enter a zip code and display a message indicating whether the zip code is one which the company delivers.
*/

// Prompt the user to enter a zip code
Console.WriteLine("Enter your zip code for delivery");
// Store the zip code entered by the user
int zipCode = int.Parse(Console.ReadLine()); 

// Create the zipcodes which are available for delivery
int[] eligibleZip = { 2200, 2210, 2220, 2230, 2240, 2250, 2260, 2270, 2280, 2290 };
// Create a boolean and set it to false for checking zip
bool checkZip = false;

for (int i = 0; i < eligibleZip.Length; i++)
{
    // If zip code is in the array set checkZip to true
    if (zipCode == eligibleZip[i])
    {
        checkZip = true;
        break;
    } // Otherwise checkZip is already set to false
}

    // If checkZip is true then package is eligible for delivery
    if (checkZip == true)
    {
        Console.WriteLine($"Zip code {zipCode} IS ELIGIBLE for delivery");
    } // Else package is not eligible for delivery
    else
    {
        Console.WriteLine($"Zip code {zipCode} IS NOT ELIGIBLE for delivery");
    }
