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
int guess;

// Using loops to guess again rather than giving one chance for the user
do
{
    guess = int.Parse(Console.ReadLine());
    if (guess < randomNumber)
    {
        Console.WriteLine($"Guess {guess} is LOWER THAN random number");
    }
    else if (guess == randomNumber)
    {
        Console.WriteLine($"Guess {guess} is CORRECT");
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine($"Guess {guess} is GREATER THAN random number");
    }
} while (guess != randomNumber);
