# Single responsibility principle

Принцип єдиної відповідальності означає, що клас виконує тільки одну задачу. 

Як працює код:
- Book відповідає тільки за дані книги (назва та автор).
- BookSaver відповідає тільки за збереження книги у файл.
- Якщо треба змінити формат збереження,тоді треба змінити BookSaver.
- Якщо змінити структуру книги,тоді треба змінити Book.
  
Вони не заважають один одному, тому у кожного класу є єдина відповідальність.

```csharp
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
```
## Результат
![Результат виконання](scr1.png)
