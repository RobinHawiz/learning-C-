
string firstName = string.Empty;
string lastName = string.Empty;
string filePath1 = string.Empty;
string filePath2 = string.Empty;

firstName = "Robin";
lastName = "Hawiz";
filePath1 = "C:\\Temp\\files";
//or
filePath2 = @"C:\Temp\files";
//or
string testString = $@"The file for {firstName} is at C:\temp\files";

//String interpolation.
Console.WriteLine($"Hi {firstName} {lastName}");
Console.WriteLine(filePath1 + " is the same as " + filePath2);
Console.WriteLine(testString);