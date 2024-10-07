using Methods;
// or
using static Methods.ConsoleMessages;

ConsoleMessages.SayHi();
// or
SayHi();

// DRY - Don't Repeat Yourself
// SOLID - SRP - Single Responsibility Principle

ConsoleMessages.SayGoodbye();

MathShortcuts.Add(5, 3);

double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };

MathShortcuts.AddAll(vals);

string name = ConsoleMessages.GetUsersName();
ConsoleMessages.GreetByName(name);