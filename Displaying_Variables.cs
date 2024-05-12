// Double quotes are needed for strings otherwise they will be interpreted as a variable by the compiler
string libary = "Riverwood libary";
Console.WriteLine(library);

// Start debugging => fn + F5
// Start without debugging => Ctrl + fn + F5

// Console.Write() prints the content without adding a new line at the end
// Console.WriteLine() printst the content and adds a new line at the end

// Placeholder method to print format strings
double treeHeight = 5.453;
Console.WriteLine("The tree height is {0}", treeHeight);

string brand1 = "Mercedes", brand2 = "BMW", brand3 = "SRT";
Console.WriteLine("Formula One is sponsored by {0},{1} and {2}", brand1, brand2, brand3);

decimal decimal1 = 0.54m, decimal2 = 1.54m, decmial3 = 2.54m;
// {0,5} The 5 after the comma means the placeholder will take 5 characters
// If the text is to be on the left hand side then do {0,-5}
Console.WriteLine("Decimal 1 is {0,5}, number 2 is {1,5} and number 3 is {2,5}", decimal1, decimal2, decmial3); 

// Concatentation method
int age = 20;
string favouriteCar = "SRT Dodge Challenger";
Console.WriteLine("Sijan Acharya is " + age + " years old and likes the car " + favouriteCar);
