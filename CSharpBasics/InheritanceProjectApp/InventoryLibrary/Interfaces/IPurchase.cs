using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Interfaces;
public interface IPurchase : IInventoryItem
{
    void Purchase();
}

