using InventoryLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models;

public class ExcavatorModel : InventoryItemModel, IRental
{
    public void Dig()
    {
        Console.WriteLine("I'm digging.");
    }

    public void Rent()
    {
        QuantityInStock--;
        Console.WriteLine("This excavator has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock++;
        Console.WriteLine("The excavator has been returned");
    }
}

