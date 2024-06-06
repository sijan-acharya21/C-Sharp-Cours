// Method overloading is having different implementations of a function with the same name

// In order to overload the function needs to have the same name
// Parameters need to be different type of parameter or different number of parameters

// Inside Main method


// Outside Main method
public static void Add(int x, int y) {
  int answer = x + y;
  Console.WriteLine(answer);
}

public static void Add(string x, string y) {
  string concatenate = x + " " + y;
  Consoe.WriteLine(concatenate);
}

public static void Add(double x, double) {
  double answer
