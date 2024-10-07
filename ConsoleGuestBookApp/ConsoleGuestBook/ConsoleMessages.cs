using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGuestBook;

public static class ConsoleMessages
{
    public static bool askIfRegisterAnotherGuest()
    {
        while (true)
        {
            Console.Write("Do you want to register another party? (yes/no): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Alright, we will proceed with registering a guest and their party to the guest book...");
                return true;
            }
            else if (answer.ToLower() == "no")
            {
                Console.WriteLine("Very well. Thank you for using this guest book, we wish you have a splendid day.");
                return false;
            }
            else
            {
                Console.WriteLine("That is not a valid answer. Please write yes or no.");
                // Adds a new line for the next question to be printed.
                Console.WriteLine();
            }
        }
    }
    public static void GreetUser()
    {
        Console.WriteLine();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("@ Welcome esteemed guest! @");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine();
    }
    public static string askUserName()
    {
        Console.Write("Please state your name sir: ");
        string name = Console.ReadLine();
        // Adds a new line for the next question to be printed.
        Console.WriteLine();
        return name;
    }

    public static int askUserPartyAmount()
    {
        bool isValid;
        int amount;
        do
        {
            Console.Write("How many people does your party consist of?: ");
            isValid = int.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine();
            if (!isValid)
            {
                Console.WriteLine("You wrote a non valid number. Write a number in the form of a numeral, please.");
            }
        } while (!isValid);

        return amount;
    }
    public static void printGuestBook(Dictionary<string, int> guestBook)
    {
        int guestsInTotal = 0;
        Console.WriteLine("Guest list:");
        foreach (KeyValuePair<string, int> entry in guestBook)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Party name: {entry.Key}");
            Console.WriteLine($"Party amount: {entry.Value}");
            Console.WriteLine("---------------------");
            guestsInTotal += entry.Value;
        }
        Console.WriteLine($"The total amount of registered guests is: {guestsInTotal}");
    }
}

