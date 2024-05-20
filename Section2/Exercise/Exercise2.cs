/*
Write a program for a lawn-moving service. The lawn-mowing season lasts 20 weeks.
The weekly fee for mowing a lot under 400 square feet is $25. The fee for a lot that is 400 square feet or more, but under 600 square feet, is $35 per week.
The fee for a lot that is 600 square feet or over is $50 per week. 
Prompt the user for the length and width of a lawn, and then display the weekly mowing fee, as well as the total fee for the 20-week season.
*/

Console.WriteLine("Enter the length of the lawn");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of the lawn");
int width = int.Parse(Console.ReadLine());
int area = length * width;
int cost;
int seasonWeeks = 20;

if (area < 400) {
  cost = 25;
  Console.WriteLine($"Weekly cost is {cost * area}");
  Console.WriteLine($"Seasonal cost is ${cost * area * seasonWeeks}");
} else if (area > 400 && area < 600) {
  cost = 35;
  Console.WriteLine($"Weekly cost is {cost * area}");
  Console.WriteLine($"Seasonal cost is ${cost * area * seasonWeeks}");
} else if (area > 600) {
  cost = 50;
  Console.WriteLine($"Weekly cost is {cost * area}");
  Console.WriteLine($"Seasonal cost is ${cost * area * seasonWeeks}");
}
