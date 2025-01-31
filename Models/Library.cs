class Library
{
  public List<Book> Books { get; }

  public Library()
  {
    Books = new List<Book>();
  }

  public void AddBook(Book book)
  {
    Books.Add(book);
    Console.Clear();
    Console.WriteLine($"\n\"{book.Title}\" was added to the library.");
  }

    public void RemoveBook(string title)
    {
        var bookToRemove = Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.Clear();
            Console.WriteLine($"\n\"{title}\" was removed from the library.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"\n\"{title}\" was not found in the library.");
        }
    }


public void DisplayBooks()
{
    Console.Clear();
    
    if (Books.Count == 0)
    {
        Console.WriteLine("\nThe library is empty. Add books to view inventory.");
        return;
    }

    Console.WriteLine("\n📚 BOOKS IN THE LIBRARY:");
    Console.WriteLine("----------------------------");
    
    foreach (Book book in Books)
    {
        Console.WriteLine($"• {book}");
    }
    Console.WriteLine("----------------------------");
}

}