using ConsoleGuestBook;
using System.Runtime.InteropServices;

Dictionary<string, int> guestBook = new();
while (ConsoleMessages.askIfRegisterAnotherGuest())
{
    ConsoleMessages.GreetUser();
    string name = ConsoleMessages.askUserName();
    int partyAmount = ConsoleMessages.askUserPartyAmount();
    GuestBook.addPartyToGuestBook(guestBook, name, partyAmount);
}

ConsoleMessages.printGuestBook(guestBook);