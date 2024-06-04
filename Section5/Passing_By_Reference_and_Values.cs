// Pass means sending information to a function through it's parameters

// Anything that is a struct is a value type
// Anything that is a class is a reference type

// Passing by value
// Place the following outside Main method
public static void GiveExtraCredit(int studentGrade) {
  studentGrade += 3;
  Console.WriteLine("Student's grade after extra credit inside function {0}", studentsGrade); 
}

// Place the following information inside Main method
int student1Grade = 75;
Console.WriteLine("Student's grade before extra credit {0}", student1Grade); // 75
// The value 75 is passed to the method not the actual variable itself
GiveExtraCredit(student1Grade); // 78
Console.WriteLine("Student's grade after extra credit {0}", student1Grade); // 75

// New keyword creates a memory location

// Passing by reference
// Inside Main method
int[] grades = new int[1];
grades[0] = 75;

Console.WriteLine("Grades BEFORE array: {0}", grades[0]); // 75 before calling method
GiveExtraCreditArray(grades); // 78 when calling method
Console.WriteLine("Grades AFTER array {0}", grades[0]); // grades[0] value changed to 78 after

// Outside Main method
public static void GiveExtraCreditArray(int[] grades)
{
    grades[0] += 3;
    Console.WriteLine("Student's grade AFTER inside the array {0}", grades[0]);
}
