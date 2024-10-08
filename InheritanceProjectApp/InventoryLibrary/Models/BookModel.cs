using InventoryLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models;

public class BookModel : InventoryItemModel, IPurchase
{
    public int NumberOfPages { get; set; }

    public void Purchase()
    {
        QuantityInStock--;
        Console.WriteLine("This book has been purchased");
    }
}

