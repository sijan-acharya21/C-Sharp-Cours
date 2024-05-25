// An array is a data strucure used for storing a group of the same data type
// An element is an individual item in the array
// An index is the position of the element in the array
// The first index has the value of 0 in the array

// Syntax for creating an array
// Datatype[] variableName = new Datatype[elements];
string[] singers = new string[3];
singers[0] = "The Weeknd";
singers[1] = "New Edition";
singers[2] = "Michael Jackson";

Console.WriteLine(singers[0]);
Console.WriteLine(singers[1]);
Console.WriteLine(singers[2]);

int[] myArray = new int[3];
// First element has an index of 0
myArray[0] = 5;
// Second element has an index of 1
myArray[1] = 6;
// Third element has an index of 2
myArray[2] = 7;

Console.WriteLine(myArray[1]); // Accesses the 2nd element which is 6

// Other ways to create arrays
// Do not have to include elements inside string[] because it counts automatically
string[] playoffTeams = new string[] {"Minnesotta Timberwolves","Dallas Mavericks","Indiana Pacers","Boston Celtics"};

string[] finals = {"Cleveland Cavaliers", "Golden State Warriors"};
Console.WriteLine(finals[0]); // Cleveland Cavaliers
Console.WriteLine(finals[1]); // Golden State Warriors

// Change value of elements
finals[0] = "New England Patriots";
finals[1] = "Atlanta Falcons";

Console.WriteLine(finals[0]); // Changed from Cavaliers to New England Patriots
Console.WriteLine(finals[1]); // Changed from Warriors to Atlanta Falcons
































