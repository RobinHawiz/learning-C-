using InventoryLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models;
public class InventoryItemModel : IInventoryItem
{
    public string ProductName { get; set; }
    public int QuantityInStock { get; set; }
}
