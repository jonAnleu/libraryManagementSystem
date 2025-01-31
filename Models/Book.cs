class Book
{
  private string _title;
  private string _author;

  public string Title 
  { 
    get => _title; 
    set
    {
      if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentException("Title cannot be empty.");
      _title = value;
    }
  }

  public string Author 
  { 
    get => _author; 
    set
    {
      if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentException("Author cannot be empty.");
      _author = value;
    }
  }

  public Book(string title, string author)
  {
    Title = title;
    Author = author;
  }

  public override string ToString()
  {
    return $"\"{Title}\" by {Author}";
  }
}
