/* Write a program that asks the user for the length and width of their room. Define a constant that
 * represents the price of carpeting per square foot. Compute and display the cost of carpeting the room
*/

Console.WriteLine("Enter the length of your room?");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of your room");
int width = int.Parse(Console.ReadLine());
const int pricePerSquareFoot = 50;

int cost = pricePerSquareFoot * length * width;

Console.WriteLine($"Cost for carpeting a room {length} feet long and {width} feet wide is ${cost}");
