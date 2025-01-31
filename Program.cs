using System.Xml.Serialization;
using Spectre.Console;

var library = new Library();


while (true)
{
    Console.WriteLine("\nLibrary Management System");
    Console.WriteLine("\n1. Add a Book");
    Console.WriteLine("2. Remove a Book");
    Console.WriteLine("3. Search Library"); //need to implement menthod in library class and write logic for it below in switch case 
    Console.WriteLine("4. Library Inventory");
    Console.WriteLine("5. Exit Library");
    Console.Write("\nEnter a number to choose action: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter the title of the book you wish to add: ");
            string? title = Console.ReadLine();
            Console.Write("Enter the author of the book: ");
            string? author = Console.ReadLine();
            var book = new Book(title, author);
            library.AddBook(book);
            break;

        case "2":
            Console.Write("Enter the title of the book you wish to remove: ");
            title = Console.ReadLine();
            library.RemoveBook(title);
            break;

        case "3":
            Console.Write("Do you wish to search the library by \"title\" or \"author\": ");
            string search = Console.ReadLine();
            break;

        case "4":
            library.DisplayBooks();
            break;

        case "5":
            Console.WriteLine("Thanks for visiting the library. Have a great day!");
            return;

        default:
            Console.Clear();
            Console.WriteLine("\nInvalid entry. Please select choices 1-5.");
            break;

    }
}

