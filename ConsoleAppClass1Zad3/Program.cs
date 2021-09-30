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
    class Program
    {
        static void Main(string[] args)
        {
          
            Book book = new Book("Война", "Леха", "Про войну");
            book.Info();
 
            
            Book book1 = new Book();
            Console.WriteLine("Введите автора");
            book1.author.Author1 = Console.ReadLine();
            Console.WriteLine("Введите описание");
            book1.content.Content1 = Console.ReadLine();
            Console.WriteLine("Введите название");
            book1.title.Title1 = Console.ReadLine();

            book1.Info();

        }
    }

}
