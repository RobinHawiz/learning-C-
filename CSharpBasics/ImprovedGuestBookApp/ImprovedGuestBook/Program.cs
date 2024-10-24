using GuestBookLibrary.Models;
using ImprovedGuestBook;

GuestBookModel guestBook = GuestBookLogic.registerGuests();
ConsoleMessages.printGuestBook(guestBook);