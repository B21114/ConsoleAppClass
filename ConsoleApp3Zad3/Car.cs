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
    /// Класс машина, производный от транспорта
    /// </summary>
    class Car : Vehicle
    {
        /// <summary>
        /// Конструктор машины, все поля наследуются от базового класса
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        /// <param name="price">Цена</param>
        /// <param name="speed">Скорость</param>
        /// <param name="year">Год выпуска</param>
        public Car(double x, double y, double price, double speed, double year) : base(x, y, price, speed, year)
        {
           
        }

        /// <summary>
        /// Переопределенный метод вывода информации о машине
        /// </summary>
        public override string ToString()
        {
            return $"Координата х:{X}, Координата y:{Y}, Цена:{Price}, Скорость:{Speed}, Год выпуска:{Year}";
        }
    }
}
