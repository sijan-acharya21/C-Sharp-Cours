// If statements take an expression that evaluates to a boolean value
int age = 10;
// if keyword is used to declare an if statement and boolean expression goes inside parentheses
if (age < 18)
    Console.WriteLine("Age is less than 18"); // Will run this statement because expression is true

if (age > 18)
    Console.WriteLine("Age is greater than 18"); // Won't run anything because expression is not true

if (age > 18)
    Console.WriteLine("Age is greater than 18"); // By default only the first statement after the if statement is considered part of it
    Console.WriteLine("You can attend the party"); // This statement is considered outside the if statement so it won't run

// Both statements are included inside the if statement because of curly braces (blocks)
age = 21;
// To execute multiple statements inside the if statement use blocks
if (age > 18) {
    Console.WriteLine("Age is greater than 18"); 
    Console.WriteLine("You can attend the party");
}

bool isSoftwareEngineer = true;
// By default isSoftwareEngineer is a true or false value so it will run the statement below
if (isSoftwareEngineer) {
    Console.WriteLine("Person is a software engineer");
}

isSoftwareEngineer = false;
// Won't run the statement because value is not true
if (isSoftwareEngineer) { // Same as (isSoftwareEngineer == true)
    Console.WriteLine("Person is a software engineer");
}
// Runs the statement below if isSoftwareEngineer == false
Console.WriteLine("Person is NOT a software engineer"); // Same as (isSoftwareEngineer == true)
