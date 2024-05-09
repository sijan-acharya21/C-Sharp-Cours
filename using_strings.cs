string myString = "Sijan \" Acharya"; // Use \ to escape double quotes
Console.WriteLine(myString); // Sijan \" Acharya

string name1 = "Sijan";
string name2 = "Sijan";

bool namesEqual = name1 == name2;
Console.WriteLine("Names {0} and {1} are equal:  {2}", name1, name2, namesEqual);

string name3 = "Denzel";
string name4 = "Samuel";

// string.Equals() function returns true if both strings are the same and false when they are different
// Place the two strings inside the parentheses: string.Equals(string1, string2)
bool areNamesEqual = string.Equals(name3, name4);
Console.WriteLine("{0} and {1} are equal: {2}", name3, name4, areNamesEqual);

// Not from video: String interpolation - substitute values of variables as placeholders in strings
string artist = "The Weeknd";
// Use the $ before the double quotes and place the variables inside the curly braces
Console.WriteLine($"The artist's name is {artist}");

// string.Compare() function returns an integer
// Place the two strings being compared inside the parentheses: string.Compare(string1, string2)
// Returns -1 if the first string is less than the second string in alphabetical order
// Returns 0 if both strings are the same
// Returns 1 if first string is greater than the second string in alphabetical order
string singer1 = "Abel Tesfaye";
string singer2 = "Micheal Jackson";
int compareString = string.Compare(singer1, singer2);
Console.WriteLine(compareString); // -1

string songName = "Kiss Land";
string sameSong = "Kiss Land";
int compareSong = string.Compare(songName, sameSong);
Console.WriteLine(compareSong); // 0

string letterB = "b";
string letterA = "a";
int compareLetters = string.Compare(letterB, letterA);
Console.WriteLine(compareLetters) // 1
