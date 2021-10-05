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

    class Vehicle
    {
        double X { get; set; }
        double Y { get; set; }
        double Price { get; set; }
        double Speed { get; set; }
        double Year { get; set; }
      
    }   
    class Plane : Vehicle
    {
        double Height { get; set; }
        int Passenger { get; set; }
     
    }
    
    class Ship : Vehicle
    {
        string Port { get; set; }
        int Passenger { get; set; }

        public void Move()
        {
            Console.WriteLine("");
        }
    }
    class Car : Vehicle
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
