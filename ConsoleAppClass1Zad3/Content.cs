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
    /// Класс контент
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Свойство контент
        /// </summary>
        public string Content1 { get; set; }
        /// <summary>
        /// Конструктор по умолчанию контент
        /// </summary>
        public Content()
        {

        }
        /// <summary>
        /// Конструктор контент
        /// </summary>
        public Content(string content)
        {
            Content1 = content;
        }
        /// <summary>
        /// Метод вывода информации контента
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
            Console.WriteLine($"Описание: {Content1}");
            Console.ResetColor();
        }
    }

}
