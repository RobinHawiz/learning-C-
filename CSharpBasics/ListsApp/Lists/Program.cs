List<string> firstNames = new List<string>();

firstNames.Add("Robin");
firstNames.Add("Ronald");
firstNames.Add("McDonald");

Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);

Console.WriteLine(ages[ages.Count - 1]);

string data = "Robin,Ronald,McDonald";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Smith");