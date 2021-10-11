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
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(10,10,200000,200,1994);
            Ship ship = new Ship(1, 2, 54353454, 50, 1923, "Белозубка", 320);
            Plane plane = new Plane(4,4,12312312321321,1000,2014,10000,50);
            Console.WriteLine(car);
            Console.WriteLine(ship);
            Console.WriteLine(plane);
        }
    }
}
