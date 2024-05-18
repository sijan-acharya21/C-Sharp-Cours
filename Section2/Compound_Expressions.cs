// AND operator (&&) checks if all conditions are met
// Only true when both boolean values are true
bool greatResume = true;
bool passedCodingInterview = true;
bool hiredForJob = greatResume && passedCodingInterview;
Console.WriteLine(hiredForInterview);

// OR operator (||) checks if at least one condition is met
// Only false when both boolean values are false
bool athleteScholarship = true;
bool perfectGrades = true;
bool admissionToSchool = athleteScholarship || perfectGrades;
Console.WriteLine(admissionToSchool);

// Another age restriction program
Console.WriteLine("Enter your age");
int age = int.Parse(Console.ReadLine());
// Checks if an individual is eligible for the party
if (age >= 13 && age <= 19)
{
    Console.WriteLine("Allowed in the teenage party");
} else
{
    Console.WriteLine("Sorry, this is a teenage party");
}

// Movie discount

if (age < 12 || (age > 65 && movieRating.ToUpper() == "G"))
{
    Console.WriteLine("You get a discount");
} else
{
    Console.WriteLine("You DONT get a discount");
}































