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
    /// Класс названия книги
    /// </summary>
    public class Title
    {
        /// <summary>
        /// Свойство названия книги
        /// </summary>
        public string Title1 { get; set; }
        /// <summary>
        /// Конструктор по умолчанию названия книги
        /// </summary>
        public Title()
        {

        }
        /// <summary>
        /// Конструктор названия книги
        /// </summary>
        /// <param name="title">название</param>
        public Title(string title)
        {
            Title1 = title;
        }
        /// <summary>
        /// Метод установки цвета и вывода названия книги
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine($"Название: {Title1}");
            Console.ResetColor();
        }
    }

}
