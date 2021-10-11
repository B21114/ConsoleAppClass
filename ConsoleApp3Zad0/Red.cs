/*
Создайте класс Printer.
В теле класса создайте метод void Print(string value), который выводит на экран значение
аргумента.
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
выводились разными цветами.
Обязательно используйте приведение типов. */
using System;

namespace ConsoleApp3Zad0
{
    /// <summary>
    /// Класс красный, наследник принтера
    /// </summary>
    public class Red : Printer
    {
        /// <summary>
        /// Метод перекраски в красный
        /// </summary>
        /// <param name="value">Строка</param>
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.WriteLine(value);
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}
