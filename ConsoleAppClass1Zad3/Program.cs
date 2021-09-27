/*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание.*/
using System;

namespace ConsoleAppClass1Zad3
{


    public class Book
    {
        public Title title;
        public Author author;
        public Content content;
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
           
        }
        public Book()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }



    }
    public class Title
    {
        public string title { get; set; }
        public Title()
        {

        }
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine($"Название: {title}");
            Console.ResetColor();
        }
    }
    public class Author
    {
        public string author { get; set; }
        public Author()
        {

        }
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.WriteLine($"Автор: {author}");
            Console.ResetColor();
        }

    }
   public class Content
    {
        public string content { get; set; }
        public Content()
        {

        }
        public Content(string content)
        {
            this.content = content;
        }
       public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
            Console.WriteLine($"Описание: {content}");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()

            book.title.title = "Война";
            book.author.author = "Леха";
            book.content.content = "Про войну";
            book.title.Show();
            book.author.Show();
            book.content.Show();

          
            Book book1 = new Book();
            Console.WriteLine("Введите автора");
            book1.author.author = Console.ReadLine();
            Console.WriteLine("Введите описание");
            book1.content.content = Console.ReadLine();
            Console.WriteLine("Введите название");
            book1.title.title = Console.ReadLine();

            book1.title.Show();
            book1.author.Show();
            book1.content.Show();

        }
    }

}
