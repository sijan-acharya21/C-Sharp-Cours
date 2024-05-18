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

// This checks every single if statement even after finding the correct 
// If age entererd was 1 the program below will still check every if statement 
Console.WriteLine("Enter your age");
int age = int.Parse(Console.ReadLine());
if (age == 1)
{
    Console.WriteLine("You are 1");
}
if (age == 2 )
{
    Console.WriteLine("You are 2");
}
if (age == 3 )
{
    Console.WriteLine("You are 3");
}

// Using else if will be more efficient than using multiple if statements
// If age is 1 it will not execute the other conditions such as age == 2 and age == 3
if (age == 1)
{
    Console.WriteLine("You are 1");
}
else if (age == 2 )
{
    Console.WriteLine("You are 2");
}
else if (age == 3 )
{
    Console.WriteLine("You are 3");
}

