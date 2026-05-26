using System;

class Book
{
    private string title;
    private string author;
    private int year;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public Book() : this("Unknown", "Unknown", 0)
    {
    }

    public override string ToString()
    {
        return $"\"{Title}\" by {Author} ({Year})";
    }
}

class ReadingList
{
    private Book[] books = new Book[10];

    // INDEXER BY INDEX
    public Book this[int index]
    {
        get
        {
            if (index >= 0 && index < books.Length)
                return books[index];

            throw new IndexOutOfRangeException();
        }

        set
        {
            if (index >= 0 && index < books.Length)
                books[index] = value;
            else
                throw new IndexOutOfRangeException();
        }
    }

    // INDEXER BY TITLE
    public Book this[string title]
    {
        get
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i]?.Title == title)
                    return books[i];
            }

            return null;
        }
    }

    // INDEXER BY AUTHOR + TITLE
    public Book this[string author, string title]
    {
        get
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i]?.Author == author &&
                    books[i]?.Title == title)
                {
                    return books[i];
                }
            }

            return null;
        }
    }

    public void AddBook(Book book)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == null)
            {
                books[i] = book;
                Console.WriteLine("Book added.");
                return;
            }
        }

        Console.WriteLine("Reading list is full.");
    }

    public void RemoveBook(string title)
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i]?.Title == title)
            {
                books[i] = null;
                Console.WriteLine("Book removed.");
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }

    public bool Contains(string title)
    {
        return this[title] != null;
    }

    public void ShowBooks()
    {
        Console.WriteLine("\nReading List:");

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null)
            {
                Console.WriteLine($"{i}: {books[i]}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ReadingList list = new ReadingList();

        list.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
        list.AddBook(new Book("1984", "George Orwell", 1949));
        list.AddBook(new Book("Dune", "Frank Herbert", 1965));
        list.AddBook(new Book("From Below", "Darcy Coates", 2022));
        list.AddBook(new Book("Dead Silence", "Stacey Kade", 2022));
        list.AddBook(new Book("No Country for Old Men", "Cormac McCarthy", 2005));

        list.ShowBooks();

        Console.WriteLine();

        Console.WriteLine(list[0]);
        Console.WriteLine(list["Dune"]);
        Console.WriteLine(list["George Orwell", "1984"]);
        Console.WriteLine(list["Dead Silence"]);
        Console.WriteLine(list["Unknown Book"]);

        Console.WriteLine($"Contains Dune? {list.Contains("Dune")}");

        list.RemoveBook("1984");

        list.ShowBooks();
    }
}
