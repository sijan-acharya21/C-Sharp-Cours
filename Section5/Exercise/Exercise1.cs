/*
Create a console-based application whose Main() method asks the user to input an integer and then calls a method named MultiplicationTable,
which displays the results of multiplying the integer by each of the numbers 2 through 10
*/

Console.WriteLine("Enter a number to see multiplication table"); 
int number = int.Parse(Console.ReadLine());
MultiplicationTable(number);

public static void MultiplicationTable(int number)
{
    for (int i = 1; i < 11; i++)
    {
        int answer = number * i;
        Console.WriteLine($"{number} X {i} = {answer}");
    }
}

/*
Improvements
For loop need to have the following because the question reads from 2 to 10
- for (int i = 2; i < 11; i++)
Could also format the spaces to look good 
- Console.WriteLine($"{number, 2} X {i,2} = {answer, 2}");
*/
