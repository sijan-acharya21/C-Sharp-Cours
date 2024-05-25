// Parallel arrays are two or more arrays that have values which correspond to the same index
string[] students = {"Bob", "Ted", "Tom", "Fred"};
int[] grades = { 77, 50, 78, 99 };

Console.WriteLine("Enter student name to search for");
string studentName = Console.ReadLine();

bool contains = false;
int studentGrade = 0;

for (int i = 0; i < students.Length; i++) {
  if (studentName == students[i]) {
    contains = true;
    studentGrade = grades[i];
    break; // Break keyword will break out from the block
  }
}
if (contains == true) {
  Console.WriteLine("The student IS in class");
  Console.WriteLine("The student grade is {0}", studentGrade);
} else {
  Console.WriteLine("The student IS NOT in class");
}
