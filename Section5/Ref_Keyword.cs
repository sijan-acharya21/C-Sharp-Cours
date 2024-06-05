// When passing by value the variable value is copied into the function
// When passing by reference the actual value itself in the memory location is called into the function

// ref keyword is used to force the value type to be passed as a reference 
int number = 10;
Console.WriteLine("Value of number after BEFORE calling method: {0}", number);
IncreaseByFive(ref number);
Console.WriteLine("Value of number AFTER calling method: {0}", number);

public static void IncreaseByFive(ref int value) {
  value += 5;
  Console.WriteLine("Value of number INSIDE METHOD: {0}", value);
}
