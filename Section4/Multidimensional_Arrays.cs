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

// A jagged array is an array of arrays, that is, every row is a new array
// int[][] arrayName = new int[3][] 
int[][] jaggedArray = new int[3][]; // Jagged array will have 3 rows
jaggedArray[0] = new int[4] {1,2,3,4};
jaggedArray[1] = new int[5] {1,2,3,4,5};
jaggedArray[2] = new int[6] {1,2,3,4,5,6};

// Output the jagged array
for(int i = 0; i < 3; i++) { // i is less than 3 because it has 3 rows
    for(int j = 0; j < jaggedArray[i].Length; j++) {
        Console.Write(jaggedArray[i][j]);
    }
    Console.WriteLine();
}

// 1234
// 12345
// 123456
