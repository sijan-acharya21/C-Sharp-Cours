// Pass means sending information to a function through it's parameters

// Anything that is a struct is a value type
// Anything that is a class is a reference type

public static void GiveExtraCredit(int studentGrade) {
  studentGrade += 3;
  Console.WriteLine("Student's grade after extra credit inside function {0}", studentsGrade); 
}

// Place the following information inside Main method
int student1Grade = 75;
Console.WriteLine("Student's grade before extra credit {0}", student1Grade);
GiveExtraCredit(student1Grade);
Console.WriteLine("Student's grade after extra credit {0}", student1Grade);
