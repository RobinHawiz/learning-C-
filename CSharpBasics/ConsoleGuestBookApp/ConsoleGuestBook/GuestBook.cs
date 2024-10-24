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

    public static Dictionary<string, int> registerGuests()
    {
        Dictionary<string, int> guestBook = new();
        while (ConsoleMessages.askIfRegisterAnotherGuest())
        {
            ConsoleMessages.GreetUser();
            string name = ConsoleMessages.askUserName();
            int partyAmount = ConsoleMessages.askUserPartyAmount();
            GuestBook.addPartyToGuestBook(guestBook, name, partyAmount);
        }
        return guestBook;
    }
}

