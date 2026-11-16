using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem.Controllers;

namespace TCSA.OOP.LibraryManagementSystem;

internal class UserInterface
{
    private readonly BooksController _booksController = new();
    private readonly MagazineController _magazineController = new();
    private readonly NewspaperController _newspaperController = new();
    
    internal void MainMenu()
    {
        while (true)
        {
            Console.Clear();
    
            var actionChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.MenuAction>()
                    .Title("What do you want to do next?")
                    .AddChoices(Enum.GetValues<Enums.MenuAction>()));
            
            var itemTypeChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.ItemType>()
                    .Title("Which type of item?")
                    .AddChoices(Enum.GetValues<Enums.ItemType>()));
    
            switch (actionChoice)
            {
                case Enums.MenuAction.ViewItem:
                    ViewItems(itemTypeChoice);
                    break;
                case Enums.MenuAction.AddItem:
                    AddItem(itemTypeChoice);
                    break;
                case Enums.MenuAction.DeleteItem:
                    DeleteItem(itemTypeChoice);
                    break;
            }
        }
    }
    
    private void ViewItems(Enums.ItemType itemType)
    {
        switch (itemType)
        {
            case Enums.ItemType.Book:
                _booksController.ViewItems();
                break;
            case Enums.ItemType.Magazine:
                _magazineController.ViewItems();
                break;
            case Enums.ItemType.Newspaper:
                _newspaperController.ViewItems();
                break;
        }
    }

    private void AddItem(Enums.ItemType itemType)
    {
        switch (itemType)
        {
            case Enums.ItemType.Book:
                _booksController.AddItem();
                break;
            case Enums.ItemType.Magazine:
                _magazineController.AddItem();
                break;
            case Enums.ItemType.Newspaper:
                _newspaperController.AddItem();
                break;
        }
    }

    private void DeleteItem(Enums.ItemType itemType)
    {
        switch (itemType)
        {
            case Enums.ItemType.Book:
                _booksController.DeleteItem();
                break;
            case Enums.ItemType.Magazine:
                _magazineController.DeleteItem();
                break;
            case Enums.ItemType.Newspaper:
                _newspaperController.DeleteItem();
                break;
        }
    }
}