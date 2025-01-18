using Spectre.Console;

namespace libraryManagementSystem
{
    internal class BooksController
    {
        private List<string> books = new()
{
    "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", "The Catcher in the Rye", "The Hobbit", "Moby-Dick", "War and Peace", "The Odyssey", "The Lord of the Rings", "Jane Eyre", "Animal Farm", "Brave New World", "The Chronicles of Narnia", "The Diary of a Young Girl", "The Alchemist", "Wuthering Heights", "Fahrenheit 451", "Catch-22", "The Hitchhiker's Guide to the Galaxy"
};
        internal void ViewBooks()
        {
            AnsiConsole.MarkupLine("[yellow]List of Books:[/]");

            foreach (var book in MockDatabase.Books)
            {
                AnsiConsole.MarkupLine($"- [cyan]{book.Name}[/] - [yellow]{book.Pages} pages[/]");
            }

            AnsiConsole.MarkupLine("Press Any Key to Continue.");
            Console.ReadKey();
        }

   internal void AddBook()
{
    var title = AnsiConsole.Ask<string>("Enter the [green]title[/] of the book to add:");
    var pages = AnsiConsole.Ask<int>("Enter the [green]number of pages[/] in the book:");

    if (MockDatabase.Books.Exists(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))
    {
        AnsiConsole.MarkupLine("[red]This book already exists.[/]");
    }
    else
    {
        var newBook = new Book(title, pages);
        MockDatabase.Books.Add(newBook);
        AnsiConsole.MarkupLine("[green]Book added successfully![/]");
    }

    AnsiConsole.MarkupLine("Press Any Key to Continue.");
    Console.ReadKey();
}

        internal void DeleteBook()
    {
        if (MockDatabase.Books.Count == 0)
        {
            AnsiConsole.MarkupLine("[red]No books available to delete.[/]");
            Console.ReadKey();
            return;
        }

        var bookToDelete = AnsiConsole.Prompt(
            new SelectionPrompt<Book>()
                .Title("Select a [red]book[/] to delete:")
                .AddChoices(MockDatabase.Books));

        if (MockDatabase.Books.Remove(bookToDelete))
        {
            AnsiConsole.MarkupLine("[red]Book deleted successfully![/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Book not found.[/]");
        }

        AnsiConsole.MarkupLine("Press Any Key to Continue.");
        Console.ReadKey();
    }

    }
}