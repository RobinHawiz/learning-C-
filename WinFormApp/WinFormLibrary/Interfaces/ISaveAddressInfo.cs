using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormLibrary.Models;

namespace WinFormLibrary.Interfaces;

public interface ISaveAddressInfo
{
    void SaveAddressInfo(string streetAddress, string city);
}

