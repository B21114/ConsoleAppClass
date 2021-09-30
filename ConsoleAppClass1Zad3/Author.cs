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
    /// Класс автора книги
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Свойство автор
        /// </summary>
        public string Author1 { get; set; }
        /// <summary>
        /// Конструктор по умолчанию для автора
        /// </summary>
        public Author()
        {

        }
        /// <summary>
        /// Конструктор Автора
        /// </summary>
        /// <param name="author">Автор</param>
        public Author(string author)
        {
            Author1 = author;
        }
        /// <summary>
        /// Метод вывода автора
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.WriteLine($"Автор: {Author1}");
            Console.ResetColor();
        }

    }

}
