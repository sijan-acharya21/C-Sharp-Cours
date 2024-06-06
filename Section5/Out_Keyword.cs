/*
- Use out keyword if the variable is unassigned
- out keyword is placed before 
*/

// Inside Main method
int englishMark; // Unassigned variable
MarkModeration(out englishMark); // English mark after moderation
Console.WriteLine("English mark AFTER calling function: {0}", englishMark);

// Outside Main method
public static void MarkModeration(out int mark)
{
    mark = 0;
    Console.WriteLine("English mark INSIDE METHOD BEFORE increment: {0}", mark);
    mark += 5;
    Console.WriteLine("English mark INSIDE METHOD AFTER increment: {0}", mark);
}

// Inside Main method
int addNum;
int multiplyNum;
AddAndMultiply(4,5, out addNum, out multiplyNum);
Console.WriteLine(addNum);
Console.WriteLine(multiplyNum);

// Outside Main method
public static void AddAndMultiply(int a, int b, out int added, out int multiplied)
{
    added = a + b;
    multiplied = a * b;
}
