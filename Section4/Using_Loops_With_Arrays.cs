// Using loops with arrays
int[] grades = {66, 88, 95, 90, 100};
// Subscript is the item number or the index
Console.WriteLine(grades[0]);

// Output each element in the array
for (int i = 0; i < 5; i++) { // i is the index, is less than 5 because of 4 elements, increments by 1
  Console.WriteLine(grades[i]); // Output each element from the array
}

// Length property is used for finding the number of elements in the array
for (int i = 0; i < grades.Length; i++) {
  Console.WriteLine(grades[i]);
}

// Giving the students 3 extra credit points
for (int i = 0; i < grades.Length; i++) {
  grades[i] += 3;
  Console.WriteLine(grades[i]);
}

// Foreach loop
// Variable score is read only, cannot make changes using foreach loop
// Cannot reverse the order or manipulate the elements using foreach loop
foreach (int score in grades) {
  Console.WriteLine(score);
}

// Reverse the order
for (int i = grades.Length - 1; i > -1; i--) {
  Console.WriteLine(grades[i]);
}


































