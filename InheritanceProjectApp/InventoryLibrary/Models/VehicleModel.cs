using InventoryLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models;

public class VehicleModel : InventoryItemModel, IPurchase, IRental
{
    public decimal DealerFee { get; set; }

    public void Purchase()
    {
        QuantityInStock--;
        Console.WriteLine("This vehicle has been purchased");
    }

    public void Rent()
    {
        QuantityInStock--;
        Console.WriteLine("This vehicle has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock++;
        Console.WriteLine("The vehicle has been returned");
    }
}

