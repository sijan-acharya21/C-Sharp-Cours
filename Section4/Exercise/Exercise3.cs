/*
Create a game similar to Hangman in which a player guesses letters to try to replicate a hidden word.
Store at least eight words in an array and randomly select one to be the hidden word.
Initially, display the hidden word using asterisks to represent each letter.
Allow the user to guess letters to replace the asterisks in the hidden word until the user completes the entire word.
If the user guesses a letter that is not in the hidden word, display an appropriate message.
If the user guesses a letter that appears multiple times in the hidden word, make sure that each correct letter is placed.

HINT
You will need to know about strings internal array
strings Contains method
strings Remove method
strings Insert method
strings Length method
*/

// Store at least eight words in the array
string[] list = { "react", "sql", "html", "css", "javascript", "docker", "java", "github" };

// Select a random word from the array
Random random = new Random(); // Ra
int number = random.Next(0, 8); // Minimum index is 0 and max is 7
string word = list[number];
string hiddenWord = "";

// Display the hidden word using asterisks
for (int i = 0; i < word.Length; i++)
{
    hiddenWord += "*";
}

 while (hiddenWord.Contains("*"))
 {
     Console.WriteLine(hiddenWord);
     Console.WriteLine("Guess a letter in the word");
     char letter = char.Parse(Console.ReadLine());
     bool containsLetter = false;
     
for (int i = 0; i < word.Length; i++) 
{
     if (word[i] == letter) 
     {
         hiddenWord = hiddenWord.Remove(i, 1);
         hiddenWord = hiddenWord.Insert(i, letter.ToString());
         containsLetter = true;
     }
}
    if (containsLetter == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Yes, {letter} IS IN the word");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Sorry, {letter} IS NOT in the word");
    }
    Console.ResetColor();
}
