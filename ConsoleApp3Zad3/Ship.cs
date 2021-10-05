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
    /// Класс корабль, производный от транспорта
    /// </summary>
    class Ship : Vehicle
    {

        /// <summary>
        /// Свойство порт
        /// </summary>
        string Port { get; set; }

        /// <summary>
        /// Свойство пассажиры
        /// </summary>
        int Passenger { get; set; }

        /// <summary>
        /// Конструктор кораблей поля наследуются от базового класса, кроме порта и пассажиров
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <param name="price">Цена</param>
        /// <param name="speed">Скорость</param>
        /// <param name="year">Год выпуска</param>
        /// <param name="port">Порт</param>
        /// <param name="passenger">Пассажиры</param>
        public Ship(double x, double y, double price, double speed, double year, string port, int passenger) : base(x, y, price, speed, year)
        {
            Port = port;
            Passenger = passenger;
        }

        /// <summary>
        /// Переопределенный метод вывода информации о корабле
        /// </summary>
        public override void Info()
        {
            Console.WriteLine($"Координата х:{X}, Координата y:{Y}, Цена:{Price}, Скорость:{Speed}, Год выпуска:{Year}, Порт: {Port}, Количество пассажиров:{Passenger}");
        }
    }
}
