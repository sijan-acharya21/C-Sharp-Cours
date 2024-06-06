// Inside Main method
int[] myArray = {1,2,3,4,5};
PrintArray(myArray);
Console.WriteLine(



// Outside Main method
public static void PrintArray(int[] array) {
  for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]);
  }
}

// params keyword allows you to enter any amount of argument
