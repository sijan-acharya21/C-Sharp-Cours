// An normal array is called a one dimensional array
int[] array = new int[];

// There are two types of multidimensional arrays - Rectangular and Jagged arrays

// Rectangular array has the same amount of columns in every row
// Jagged array has irregular amount of columns in every row

// A two dimensional rectangular array has the following syntax
// 7 is the number of rows and 10 is the number of columns in the array
int[,] twoDimensionalArray = new int[7, 10];

// A three dimensional rectangular array has the following syntax
int[,,] threeDimensionalArray = new int[5,5];

// Creating a rectangular array with 3 rows and 4 columns
int[,] myArray = new int[3,4]

myArray[0, 0] = 1;
myArray[0, 1] = 2;
myArray[0, 2] = 3;
myArray[0, 3] = 4;

myArray[1, 0] = 1;
myArray[1, 1] = 2;
myArray[1, 2] = 3;
myArray[1, 3] = 4;

myArray[2, 0] = 1;
myArray[2, 1] = 2;
myArray[2, 2] = 3;
myArray[2, 3] = 4;

/* 
The array above "myArray" has the following shape
1 2 3 4
1 2 3 4
1 2 3 4
*/

// Another way to declare rectangular arrays
// Every row is placed inside curly braces
int[,] anotherArray = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

// Output the values inside the array above
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++) 
    {
        Console.Write(anotherArray[i,j]);
    }
    Console.WriteLine();
}
