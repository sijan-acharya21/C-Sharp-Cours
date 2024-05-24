/*
EDIT TO USE LOOPS

Write a program that generates a random number between 1 and 10.
Ask a user to guess the random number, then display the random number and a message indicating whether the user's guess was too high, too low or correct.

You can create a random number that is at least min but less than max using the following statements
Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(min, max); 1, 11
*/

// Generate a random number between 1 and 10
Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(1, 11);


Console.WriteLine("Enter your guess");
int guess; // Declaring the guess variable to which will be inside the do-while loop

// Using loops to guess again rather than giving one chance for the user
do
{
    // Store integer from the user
    guess = int.Parse(Console.ReadLine());
    // Guess is lower than random number
    if (guess < randomNumber)
    {
        Console.WriteLine($"Your number {guess} is TOO LOW");
    }
    // Guess is correct
    else if (guess == randomNumber)
    {
        Console.WriteLine($"Your number {guess} is CORRECT");
    }
    // Guess is higher than random number
    else if (guess > randomNumber)
    {
        Console.WriteLine($"Your number {guess} is TOO HIGH");
    }
} while (guess != randomNumber); // If guess IS NOT random number loop the body above
