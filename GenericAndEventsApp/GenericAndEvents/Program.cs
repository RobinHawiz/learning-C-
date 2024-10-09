using System.Runtime.CompilerServices;

List<PersonModel> people = new List<PersonModel>
{
    new PersonModel{ FirstName = "Joe", LastName = "Bidendarnit", Email = "Joe@gov.com"},
    new PersonModel{ FirstName = "Jimmy", LastName = "Eagle", Email = "Jimmy@gmail.com"},
    new PersonModel{ FirstName = "Hermano", LastName = "Sanches", Email = "Hermano@gringo.com"}
};

List<CarModel> cars = new List<CarModel>
{
    new CarModel{ Manufacturer = "Toyota", Model = "DARNCorolla"},
    new CarModel{ Manufacturer = "Toyota", Model = "Highlander"},
    new CarModel{ Manufacturer = "Ford", Model = "Mustang"}
};

DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
DataAccess<CarModel> carData = new DataAccess<CarModel>();

peopleData.BadEntryFound += PeopleData_BadEntryFound;
carData.BadEntryFound += CarData_BadEntryFound;

peopleData.SaveToCSV(people, @"C:\Temp\SavedFiles\people.csv");
carData.SaveToCSV(cars, @"C:\Temp\SavedFiles\cars.csv");


void PeopleData_BadEntryFound(object? sender, PersonModel e)
{
    Console.WriteLine($"Bad Entry Found for {e.FirstName} {e.LastName}");
}
void CarData_BadEntryFound(object? sender, CarModel e)
{
    Console.WriteLine($"Bad Entry Found for {e.Manufacturer} {e.Model}");
}

public class DataAccess<T> where T : new()
{
    public event EventHandler<T> BadEntryFound;
    public void SaveToCSV(List<T> items, string filePath)
    {
        List<string> rows = new List<string>();
        T entry = new T();
        var cols = entry.GetType().GetProperties();

        string row = "";

        foreach (var col in cols)
        {
            row += $",{col.Name}";
        }
        row = row.Substring(1);
        rows.Add(row);

        foreach (var item in items)
        {
            row = "";
            bool badWordDetected = false;

            foreach (var col in cols)
            {
                string val = col.GetValue(item, null).ToString();

                badWordDetected = BadWordDetector(val);
                if (BadWordDetector(val) == true)
                {
                    BadEntryFound?.Invoke(this, item);
                    break;
                }

                row += $",{val}";
            }
            if (!badWordDetected)
            {
                row = row.Substring(1);
                rows.Add(row);
            }
        }

        File.WriteAllLines(filePath, rows);
    }

    private bool BadWordDetector(string stringToTest)
    {
        bool output = false;
        string lowerCaseTest = stringToTest.ToLower();

        if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
        {
            output = true;
        }

        return output;
    }
}