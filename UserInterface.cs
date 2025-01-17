using Spectre.Console;
using static libraryManagementSystem.Enums;

namespace libraryManagementSystem;

internal class UserInterface
{
    internal static void MainMenu()
    {
        while (true)
        {
            var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<MenuOption>()
                    .Title("What do you want to do next?")
                    .AddChoices(Enum.GetValues<MenuOption>()));

            switch (choice)
            {
                case MenuOption.Viewbooks:
                    BooksController.ViewBooks();
                    break;
                case MenuOption.AddBook:
                    BooksController.AddBook();
                    break;
                case MenuOption.DeleteBook:
                    BooksController.DeleteBook();
                    break;
            }
        }
    }
}