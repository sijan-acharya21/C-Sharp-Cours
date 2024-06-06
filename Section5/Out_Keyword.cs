/*
- Use out keyword if the variable is unassigned
- out keyword is placed before 
*/

// Inside Main method
int englishMark; // Unassigned variable
MarkModeration(out englishMark); // English mark INSIDE method: 5
Console.WriteLine("English mark AFTER moderation: {0}", englishMark); // English mark after calling function: 5

// Outside Main method
public static void MarkModeration(out int mark) {
  mark = 0; // Have to set a value for out parameter
  mark += 5;
  Console.WriteLine("English mark INSIDE METHOD: {0}", mark);
}
