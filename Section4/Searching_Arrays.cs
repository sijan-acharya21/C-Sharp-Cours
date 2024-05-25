string[] students = {"Bob", "Ted", "Tom", "Fred"};

Console.WriteLine("Enter student name to search for");
string studentName = Console.ReadLine();
bool containsName = false;
for (int i = 0; i < students.Length; i++) {
  if (studentName == students[i]) {
    contains == true;
  }
}
if (contains == true) {
  Console.WriteLine("The student IS in class");
} else {
  Console.WriteLine("The student IS NOT in class");
}
