int age = 50;
// If the boolean below is true then it runs the if block
if (age < 18)
{
    Console.WriteLine("This is the true");
} else // If the boolean above is false then it runs the else block
{
    Console.WriteLine("This is the false");
}

// Age restriction program
Console.WriteLine("Enter your age");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("You're good to go");
} else
{
    Console.WriteLine("Sorry, you aren't 18 yet");
}
