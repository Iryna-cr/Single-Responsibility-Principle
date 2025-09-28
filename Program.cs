using System;
using System.IO;

class Book
{
    public required string Title { get; set; }
    public required string Author { get; set; }
}

class BookSaver
{
    public void Save(Book book)
    {
        File.WriteAllText("book.txt", $"{book.Title} by {book.Author}");
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book { Title = "1984", Author = "George Orwell" };
        BookSaver saver = new BookSaver();
        saver.Save(book);
        Console.WriteLine("Book saved!");
    }
}

