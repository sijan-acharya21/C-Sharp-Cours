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
Console.WriteLine("Enter the day of the week")
int day = int.Parse(Console.ReadLine());

