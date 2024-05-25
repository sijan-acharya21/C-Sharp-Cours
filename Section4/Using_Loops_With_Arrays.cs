// Using loops with arrays
int[] grades = {66, 88, 95, 90, 100};
// Subscript is the item number or the index
Console.WriteLine(grades[0]) // How to say this (Grades subscript 0 OR Grades index 0)
for (int i = 0; i < grades.Length; i++) {
  grades[i] += 3;
  Console.WriteLine(grades[i]);
}
