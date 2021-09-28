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

    /// <summary>
    /// Класс книга
    /// </summary>
    public class Book
    {
        public Title title;
        public Author author;
        public Content content;
        /// <summary>
        /// Метод книга
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="author">Автор</param>
        /// <param name="content">Описание</param>
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        /// <summary>
        /// Метод для пустых полей книги
        /// </summary>
        public Book()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        /// <summary>
        /// Метод вывода информации о книге
        /// </summary>
        public void Info()
        {
            title.Show();
            author.Show();
            content.Show();
        }


    }
    /// <summary>
    /// Класс названия книги
    /// </summary>
    public class Title
    {
        public string title { get; set; }
        public Title()
        {

        }
        /// <summary>
        /// Метод присвоения названия названию???
        /// </summary>
        /// <param name="title">название</param>
        public Title(string title)
        {
            this.title = title;
        }
        /// <summary>
        /// Метод установки цвета и вывода названия книги
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine($"Название: {title}");
            Console.ResetColor();
        }
    }
   /// <summary>
   /// Класс автора книги
   /// </summary>
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
          
            Book book = new Book("Война", "Леха", "Про войну");
            book.Info();
 
            
            Book book1 = new Book();
            Console.WriteLine("Введите автора");
            book1.author.author = Console.ReadLine();
            Console.WriteLine("Введите описание");
            book1.content.content = Console.ReadLine();
            Console.WriteLine("Введите название");
            book1.title.title = Console.ReadLine();

            book1.Info();

        }
    }

}
