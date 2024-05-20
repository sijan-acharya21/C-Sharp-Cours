/*
Write a program that generates a random number between 1 and 10.
Ask a use to guess the random number, then display the random number and a message indicating whether the user's guess was too high, too low or correct

Hint:
You can create a random number that is at least min but less than max using the following statements
Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(min, max);
*/

// Instantiate random number generator
Random randomGenerator = new Random();
// Random.Next(mininum, maximum) generates a random number with minimum and maximum
int randomNumber = randomGenerator.Next(1, 11); // Minimum (1) and Maximum (10, 11 is exclusive)

Console.WriteLine("Guess the random number");
int guess = int.Parse(Console.ReadLine());

if (guess < randomNumber) {
  Console.WriteLine($"Your guess {guess} is LESS THAN {randomNumber}");
} else if (guess == randomNumber) {
  Console.WriteLine($"Your guess {guess} is CORRECT");
} else if (guess > randomNumber) {
  Console.WriteLine($"Your guess {guess} is GREATER THAN {randomNumber}");
}
