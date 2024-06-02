// Program starts running from the Main method
// A method (function) is an action in programming - WriteLine() is a method for the Console library

// Access modifiers - public means anyone can use this method, private means only the class itself can use this method
// Return type is the result of the method or the answer which is returned
// Void means there is no return type

// Creating a method synta
// accessModifier static returnType methodName

public static void DisplayMessage() {
 Console.WriteLine("Hello World");
}
// Parameters are the information the method needs to complete the task
// The arguments passed for the function has to be in the correct order
public static void Add(int number1, int number2) {
 int answer = number1 + number2;
 Console.WriteLine(answer);
}

// Instead of using void a return type can be used to store the value returned
// A return is useful because it can be stored and used somewhere else
public static double CalculatePay(double hourlyRate, double hoursWorked) {
 double output = hourlyRate * hoursWorked;
 return output;
}

double answer = CalculatePay(29,80);
Console.WriteLine(answer);


















