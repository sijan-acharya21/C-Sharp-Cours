// Booleans can only hold the value of true or false or an expression which evaluates to true or false
bool myBoolean = true;

// Comparison operators: >, >=, <, <=, ==, !=
bool sixGreaterThanSeven = 6 > 7;
Console.WriteLine("Six is greater than seven: {0}", sixGreaterThanSeven);
bool sixGreaterThanOrEqualToSeven = 6 >= 7;
Console.WriteLine("Six is greater than or equal to seven: {0}", sixGreaterThanOrEqualToSeven);
bool sixLessThanSeven = 6 < 7;
Console.WriteLine("Six is less than seven: {0}", sixLessThanSeven);
bool sixLessThanOrEqualToSeven = 6 <= 7;
Console.WriteLine("Six is less than or equal to seven: {0}", sixLessThanOrEqualToSeven);
bool sixEqualToSeven = 6 == 7;
Console.WriteLine("Six is equal to seven: {0}", sixEqualToSeven);
bool sixNotEqualToSeven = 6 != 7;
Console.WriteLine("Six is not equal to seven: {0}", sixNotEqualToSeven);

int hoursWorked = 25;
bool doesEmployeeGetOvertime = hoursWorked > 40;
Console.WriteLine("Does employee get overtime?: {0}", doesEmployeeGetOvertime);
