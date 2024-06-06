// Method overloading is having different implementations of a function with the same name

// In order to overload the function needs to have the same name
// Parameters need to be different type of parameter or different number of parameters

// Inside Main method
Add(5,6); // 11
Add("Hello", "World"); // Hello World
Add(5.5, 8.3); // 13.8

// Outside Main method
public static void Add(int x, int y) {
  int answer = x + y;
  Console.WriteLine(answer);
}

public static void Add(string x, string y) {
  string concatenate = x + " " + y;
  Console.WriteLine(concatenate);
}

public static void Add(double x, double y) {
  double answer = x + y;
  Console.WriteLine(answer);
}
