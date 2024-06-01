/*
Write a program that allows a teacher to enter in an amount of students.
For each student ask the teacher to enter in their name and final score for the class.
When the teacher is done entering the data, print the hightest grade in the class, and the average grade for the class.
*/

Console.WriteLine("Enter the amount of students in your class");
int students = int.Parse(Console.ReadLine());
string[] name = new string[students];
int[] grade = new int[students];
int sum = 0;
int highestGrade = 0;

for (int i = 0; i < students; i++) {
  Console.WriteLine("Enter the name of the student");
  name[i] = Console.ReadLine();
  Console.WriteLine("Enter the final grade of the student");
  grade[i] = int.Parse(Console.ReadLine());
  sum += grade[i];

  if (grade[i] > highestGrade) {
  highestGrade = grade[i];
  }
}

int averageGrade = sum / students;
Console.WriteLine($"Average grade: {averageGrade}");
Console.WriteLine($"Highest grade: {highestGrade}");
