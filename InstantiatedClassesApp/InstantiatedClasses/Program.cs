using InstantiatedClasses;

PersonModel person = new PersonModel();

person.FirstName = "Robin";
person.LastName = "Horton";
person.Age = 30;
person.SSN = "123456-7891";

Console.WriteLine(person.SSN);