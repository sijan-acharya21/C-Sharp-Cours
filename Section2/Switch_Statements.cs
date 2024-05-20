// Switch statements can only check for exact value cannot use comparison operators
Console.WriteLine("Enter university year");
int universityYear = int.Parse(Console.ReadLine());

switch (universityYear) {
    case 1:
        {
            Console.WriteLine("Freshman");
            break; // Break statement will leave the switch statement because a case is chosen and does not execute other cases
        }
    case 2:
        {
            Console.WriteLine("Sophomore");
            break;
        }
    case 3:
        {
            Console.WriteLine("Junior");
            break;
        }
    case 4:
        {
            Console.WriteLine("Senior");
            break;
        }
    default:
        {
            Console.WriteLine("Invalid year");
            break;
}

// Break statement is not need when there is no body for the case
Console.WriteLine("Enter the rating of your eNPS Telstra survey");
int eNPSRating = int.Parse(Console.ReadLine());

switch (eNPSRating)
{
    case 0: 
        {
            Console.WriteLine("Not good");
            break;
        }
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
        {
            Console.WriteLine("Good");
            break;
        }
    case 8:
        {
            Console.WriteLine("Great");
            break;
        }
    case 9:
        {
            Console.WriteLine("Excellent");
            break;
        }
    case 10:
        {
            Console.WriteLine("Outstanding");
            break;
        }
    default:
        {
            Console.WriteLine("Invalid number for rating");
            break;
        }
        
