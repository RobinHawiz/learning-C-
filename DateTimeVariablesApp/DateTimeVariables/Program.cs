using System.Globalization;

DateTime today = DateTime.Now;
DateTime todayUTC = DateTime.UtcNow;

// DateTime birthday = DateTime.Parse("6/15/1998");

// Dont worry about what culture you're in and how they do formatting. We do our own formatting.
DateTime birthday = DateTime.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(today.ToString("MMM dd, yyyy hh:mm tt zzz"));
