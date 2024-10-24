using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Interfaces;
public interface IRental : IInventoryItem
{
    void Rent();
    void ReturnRental();
}
