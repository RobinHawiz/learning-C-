string[] firstNames = new string[5];

firstNames[0] = "Robin";
firstNames[1] = "Mary";
firstNames[2] = "Sofia";
firstNames[4] = "Jane";

Console.WriteLine(firstNames[1]);

firstNames[1] = "Bob";

Console.WriteLine(firstNames[1]);

// single quote identifies a char
string data = "Robin,Mary,Sofia,Bob,Tim";
string[] firstNamesData = data.Split(',');
Console.WriteLine(firstNamesData[0]);
Console.WriteLine(firstNamesData.Length);

string[] lastNames = new string[] { "Robin", "Mary", "Sofia" };

int[] ages = new int[] { 2, 3, 4 };