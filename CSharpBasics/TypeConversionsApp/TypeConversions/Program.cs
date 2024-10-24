Console.Write("What is your age?: ");
string? ageText = Console.ReadLine();

//int age = int.Parse(ageText);
bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}");

double testDouble = age;
// Casting
decimal testDecimal = (decimal)testDouble;