// When program is run it closes immendiately because it is not waiting for any input
Console.WriteLine("What is your name?");

// Console.ReadLine() is always written in as a string
// Console.ReadLine() is waiting at the console for the user to press Enter
string name = Console.ReadLine();

Console.WriteLine("Hello, {0}", name);
