// A loop is something that repeats an action

// While loop will iterate the condition as long as it is true
int a = 1;
while (a > 0) {
  Console.WriteLine("Hello"); // Infinite loop
}

/*
A definite loop is one that terminates
An indefinite loop is unknown when to end


To create a definite loop
1. A condition
2. Counter control variable
3. Alter counter control variable to make the loop terminate

*/
int x = 0;
while (x < 5) {
  Console.WriteLine("Hello");
  x++;
}

// Add numbers until -1 is entered
int sum = 0; // Sum is set to 0
Console.WriteLine("Enter a number"); // Output prompt for user
int number = int.Parse(Console.ReadLine()); // Store input from user

while (number != -1)
{
    sum += number; // Sum is set to input number from user
    Console.WriteLine("Enter another number to be added"); 
    number = int.Parse(Console.ReadLine()); // Store another number
}
Console.WriteLine($"The total is {sum}"); // Break when -1 is entered
