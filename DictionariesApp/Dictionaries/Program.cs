Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "not a human that lives on land";
lookup["fish"] = "not a human that lives underwater";
lookup["human"] = "a human";

Console.WriteLine($"The definition of fish is {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Robin Bokström";
employees[28] = "John Doe";

Console.WriteLine($"The employee with ID number 28 is {employees[28]}");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Monday"] = 1;
dayOfWeek["Tuesday"] = 2;
dayOfWeek["Wednesday"] = 3;

Console.WriteLine($"Monday is day number {dayOfWeek["Monday"]}");