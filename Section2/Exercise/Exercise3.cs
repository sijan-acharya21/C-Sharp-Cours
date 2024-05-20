/*
Write a program that generates a random number between 1 and 10.
Ask a use to guess the random number, then display the random number and a message indicating whether the user's guess was too high, too low or correct

Hint:
You can create a random number that is at least min but less than max using the following statements
Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(min, max);
*/

Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(1, 10);
Console.WriteLine(randomGenerator)

Console.WriteLine("Guess the random number");
int guess = int.Parse(Console.ReadLine());

if (guess < randomNumber) {
  Console.WriteLine($"Your guess {guess} was less than the random number {randomNumber}");
} else if (guess == randomNumber) {
  Console.WriteLine("Correct, you guessed the random number {randomNumber}");
} else if (guess > randomNumber) {
  Console.WriteLine("Your guess {guess} was greater than the random number {randomNumber}");
}
