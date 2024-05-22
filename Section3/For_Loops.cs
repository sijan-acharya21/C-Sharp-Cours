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

Console.WriteLine("Enter an amount of times to print hello");
int timesPrint = int.Parse(Console.ReadLine());
for (int i = 0; i < timesPrint; i++) {
 Console.WriteLine("Hello");
}
