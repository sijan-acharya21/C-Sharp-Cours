string myString = "Sijan \" Acharya"; // Use \ to escape double quotes
Console.WriteLine(myString); // Sijan \" Acharya

string name1 = "Sijan";
string name2 = "Sijan";

bool namesEqual = name1 == name2;
Console.WriteLine("Names {0} and {1} are equal:  {2}", name1, name2, namesEqual);

string name3 = "Denzel";
string name4 = "Samuel";

bool areNamesEqual = string.Equals(name3, name4);
Console.WriteLine("{0} and {1} are equal: {2}", name3, name4, areNamesEqual);

// String interpolation - substitute values of variables as placeholders in strings
string artist = "The Weeknd";
// Use the $ before the double quotes and place the variables inside the curly braces
Console.WriteLine($"The artist's name is {artist}");
