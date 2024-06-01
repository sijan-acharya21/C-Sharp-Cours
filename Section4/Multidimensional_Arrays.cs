// One dimensional array
int[] myArray = { 5, 6, 7 };

// There are two types of multidimensional arrays - rectangular and jagged arrays

// Rectangular array is structured like a rectangular structure

// Creating a multidimensional array

int[,] myArray = new int[3, 4];
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

// 1 2 3 4
// 1 2 3 4
// 1 2 3 4

// Short hand for the array above
int[,] myArrayDuplicate = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++) 
    {
        Console.Write(myArrayDuplicate[i,j]);
    }
    Console.WriteLine();
}
