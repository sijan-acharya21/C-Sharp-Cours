// When program is run it closes immendiately because it is not waiting for any input
Console.WriteLine("This is user input");

// Console.ReadLine() is always written in as a string
// Console.ReadLine() is waiting at the console for the user to press Enter
Console.WriteLine("What is your first name?"); 

string firstName = Console.ReadLine();

Console.WriteLine("What is your last name?");

string lastName = Console.ReadLine();

Console.WriteLine($"Hello, {firstName} {lastName}");
