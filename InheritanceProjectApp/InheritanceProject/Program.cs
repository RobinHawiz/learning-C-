using InventoryLibrary.Models;
using InventoryLibrary.Interfaces;

List<IRental> rentables = new List<IRental>();
List<IPurchase> purchasable = new List<IPurchase>();

var vehicle = new VehicleModel { ProductName = "Kia Optima", DealerFee = 25 };
var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };
var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

rentables.Add(vehicle);
rentables.Add(excavator);

purchasable.Add(book);
purchasable.Add(vehicle);

Console.Write("Do you want to rent or purchase something: (rent, purchase) ");
string rentalDecision = Console.ReadLine();

if (rentalDecision.ToLower() == "rent")
{
    foreach (var item in rentables)
    {
        Console.WriteLine($"Item: {item.ProductName}");
        Console.Write("Do you want to rent this product (yes/no): ");
        string wantToRent = Console.ReadLine();

        if (wantToRent.ToLower() == "yes")
        {
            item.Rent();
        }

        Console.Write("Do you want to return your rented item (yes/no): ");
        string wantToReturn = Console.ReadLine();

        if (wantToReturn.ToLower() == "yes")
        {
            item.ReturnRental();
        }
    }
}

else
{
    foreach (var item in purchasable)
    {
        Console.WriteLine($"Item: {item.ProductName}");
        Console.Write("Do you want to purchase this product (yes/no): ");
        string wantToPurchase = Console.ReadLine();

        if (wantToPurchase.ToLower() == "yes")
        {
            item.Purchase();
        }
    }
}