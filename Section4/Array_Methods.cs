// Linear search or sequential search checks each element in the array
// Binary search is more efficient than linear search - array must be in order before searching

int[] array = { 10, 15, 20, 25, 30, 35, 40, 45 };
Console.WriteLine("Enter number to check if it exists");
int number = int.Parse(Console.ReadLine());

// Binary search method
// Array.BinarySearch(arrayName, value)
// Returns index of element is value is found
// Returns -1 if value is not found

int answer = Array.BinarySearch(array, number);

if (answer < 0) {
  Console.WriteLine("Number DOES NOT exist in the array");
} else {
  Console.WriteLine("{0} EXISTS in the array at index {1}", number, answer);
}

// Sort method - Rearrange array elements in ascending order
// Array.Sort(arrayName);
int[] secondArray = { 10, 5, 7, 2, 55 };
Array.Sort(secondArray);

for (int i = 0; i < secondArray.Length; i++) {
  Console.WriteLine(secondArray[i]);
}

// Reverse method - Rearrange array elements in reverse order
// Array.Reverse(arrayName);
int[] thirdArray = { 10, 5, 7, 2, 55 };
Array.Reverse(thirdArray);

for (int i = 0; i < thirdArray.Length; i++) {
  Console.WriteLine(thirdArray[i]);
}
