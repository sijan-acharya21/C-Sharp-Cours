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
