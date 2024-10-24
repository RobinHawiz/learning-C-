using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

namespace ImprovedGuestBook;

public static class GuestBookLogic
{
    public static GuestBookModel registerGuests()
    {
        GuestBookModel guestBook = new GuestBookModel();
        while (ConsoleMessages.askIfRegisterAnotherGuest())
        {
            GuestModel guest = new GuestModel();
            ConsoleMessages.GreetUser();
            guest.partyName = ConsoleMessages.askUserName();
            guest.partyAmount = ConsoleMessages.askUserPartyAmount();
            guestBook.AddGuest(guest);
        }
        return guestBook;
    }
}

