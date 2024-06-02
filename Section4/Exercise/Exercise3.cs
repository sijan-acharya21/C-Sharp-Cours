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

string[] array = new string[] { "dance", "blood", "music", "movie", "skating", "basketball", "laptop", "engineer" };
Random randomGenerator = new Random();
int number = randomGenerator.Next(0, 9);
string word = array[number];
string duplicateWord = word;

int wordLength = word.Length;

for (int i = 0; i < wordLength; i++)
{
    word = word.Remove(i, 1);
    word = word.Insert(i, "*");
}
Console.WriteLine("Your word is {0} \n", word);

Console.WriteLine("Guess a letter in the word");
string guess = Console.ReadLine();

int num = duplicateWord.Contains(guess);
