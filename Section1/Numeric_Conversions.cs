// Implicit casting - automatic conversion 
int x = 3;
double y = x;
// Conversion does not have any loss of data
Console.WriteLine(y); // A double can take a whole number and decimal points

// Explicit casting - clearly telling the compiler to convert data types
double a = 5.5;
// Put the data type that you want to convert to inside parentheses next to the variable
int b = (int) a; // Telling the compiler I am going to lose data
Console.WriteLine(b);
