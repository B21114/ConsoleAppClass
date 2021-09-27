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
      
       public Book(string title, string author, string content)
        { 
        
        }
       public class Title
        {
           public string title { get; set; }
            void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.WriteLine("...");
                Console.ResetColor();
            }
        }
        class Author
        {
            string author;
            void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine("...");
                Console.ResetColor();
            }

        }
        class Content
        {
            string content;
            void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
                Console.WriteLine("...");
                Console.ResetColor();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Book book1 = new Book();
               // Book1.
            }
        }

    }
}