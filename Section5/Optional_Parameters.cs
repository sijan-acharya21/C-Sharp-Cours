public static void Add(int x, int y) { // Both parameters are mandatory
  int answer = x + y;
  Console.WriteLine(answer);
}

Add(3,6) // Both arguments are mandatory

// Optional parameter can be set when declaring the variable inside the parentheses and setting it to a value
public static void AnotherAdd(int x, int y = 1) { // int y = 1 is the default value if second argument is not given
  int answer = x + y;
  Console.WriteLine(answer);
}

AnotherAdd(5); // 6
AnotherAdd(5,10); // 15

// Named arguments all

public static void AgainAdd(int x, int y = 1, int z = 2) {
  int answer = x + y + z;
  Console.WriteLine(answer);
}

AgainAdd(5, z:5); // z:5 allows 5 to be passed in the function while y is set to 1 as default (5 + 1 + 5) = 11
AgainAdd(8, y:10); // x = 8, y = 10, z = 2 therefore (8 + 10 + 2) = 20
