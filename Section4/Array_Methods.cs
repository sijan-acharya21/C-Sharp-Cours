// Linear search or sequential search checks each element in the array
// Binary search is more efficient than linear search - array must be in order before searching

int[] myArray = { 10, 15, 20, 25, 30, 35, 40, 45 };
Console.WriteLine("Enter number to check if it exists");
int number = int.Parse(Console.ReadLine());

/*
Array.BinarySearch(arrayName, value)
- Returns index of element is value is found
- Returns -1 if value is not found
*/

int answer = Array.BinarySearch(myArray, number);

if (answer < 0) {
  Console.WriteLine("Number DOES NOT exist in the array");
} else {
  Console.WriteLine("{0} EXISTS in the array at index {1}", number, answer);
}



































