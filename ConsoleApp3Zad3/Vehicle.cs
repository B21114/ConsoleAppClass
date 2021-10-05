/*
 Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 
 */

using System;

namespace ConsoleApp3Zad3

{
    /// <summary>
    /// Базовый класс транспорт
    /// </summary>
    class Vehicle
    {
        /// <summary>
        /// Координата X
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Координата Y
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Скорость
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        public double Year { get; set; }

        /// <summary>
        /// Конструктор транспорта
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <param name="price">Цена</param>
        /// <param name="speed">Скорость</param>
        /// <param name="year">Год выпуска</param>

        public Vehicle(double x, double y, double price, double speed, double year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }

        /// <summary>
        /// Метод вывода информации, который переопределится
        /// </summary>
        public virtual void Info()
        {
            Console.WriteLine($"{X}, {Y}, {Price}, {Speed}, {Year}");
        }

    }   
}
