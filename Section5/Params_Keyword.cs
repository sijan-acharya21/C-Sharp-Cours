// Inside Main method
int[] myArray = {1,2,3,4,5};
PrintArray(myArray);
Console.WriteLine("Hello {0} {1} {2} {3}", 5, 6, 7, 8);

// Outside Main method
public static void PrintArray(int[] array) {
  for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]);
  }
}

// Inside Main method
PrintNewArray(9,10,5,6,75,4,3,5,6,75,4,6,42334,34);

// Outside Main method
// params keyword allows you to enter any amount of argument
public static void PrintNewArray(params int[] array) {
  for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]);
  }
}
