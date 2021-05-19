using System;

namespace PhoneBookConsole
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Phone Book Application");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contact by no");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search contacts for a given name ");
            Console.WriteLine("5. Press x for exit");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            while (true) {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number:");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Contact Number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Contact name to search:");
                        var searchName = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchName);
                        break;
                    case "x":
                        return ;
                    default:
                        Console.WriteLine("Number Invalid");
                        break;
                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
            
        }
    }
}
