// While loop syntax
int x = 0;
while (x < 5) {
 Console.WriteLine("Hello");
 x++;
}

// For loop syntax
for (int i = 0; i < 5; i++) { // For loop has all the components inside the parentheses
 Console.WriteLine("Hello");
}

// Printing hello based on the user input
Console.WriteLine("Enter an amount of times to print hello");
int amount = int.Parse(Console.ReadLine());
for (int i = 0; i < amount; i++) {
 Console.WriteLine("Hello");
}
