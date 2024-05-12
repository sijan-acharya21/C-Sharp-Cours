// The value of a constant cannot be changed after declaring
const double myConstant = 5;

// Accessing pi constant
const double PI = Math.PI;
Console.WriteLine(PI);

// Enumeration is the action of mentioning a number of things one by one
// Can also set the index for the enums: SUNDAY = 1, default index is 0
enum Day {
  // Index starts at 0 at default
  MONDAY, // Can also set index MONDAY = 1,
  TUESDAY,
  WEDNESDAY,
  THURSDAY,
  FRIDAY,
  SATURDAY,
  SUNDAY
}

Day tomorrow = Day.Monday;
Console.WriteLine("Tomorrow is {0}", tomorrow);

int tomorrowIndex = (int)tomorrow;
Console.WriteLine("Tomorrow is day {0}", tomorrowIndex);
