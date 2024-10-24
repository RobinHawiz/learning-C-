using ConsoleGuestBook;
using System.Runtime.InteropServices;

Dictionary<string, int> guestBook = GuestBook.registerGuests();
ConsoleMessages.printGuestBook(guestBook);