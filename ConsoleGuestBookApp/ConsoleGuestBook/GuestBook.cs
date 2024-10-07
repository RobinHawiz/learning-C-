using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGuestBook;

public static class GuestBook
{
    public static void addPartyToGuestBook(Dictionary<string, int> guestBook, string partyName, int partyAmount)
    {
        guestBook.Add(partyName, partyAmount);
    }
}

