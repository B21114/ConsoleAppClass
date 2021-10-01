/*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника.*/
using System;

namespace ConsoleAppClass1Zad4
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество сторон");
            string a = (Console.ReadLine());
            Point point = new Point(1, 5, a);
            point.LengthSide(point, point);
            point.Info();

            int b = Convert.ToInt32(a);
            if (b == 3)
            {
                Figure figure1 = new Figure(2, 2, 3);
                figure1.PerimeterCalculator(point);
                figure1.Info();
            }
            else if (b == 4)
            {
                Figure figure2 = new Figure(3, 2, 3, 4);
                figure2.PerimeterCalculator(point);
                figure2.Info();
            }
            else if (b == 5)
            {
                Figure figure3 = new Figure(3, 2, 3, 4, 5);
                figure3.PerimeterCalculator(point);
                figure3.Info();
            }
            else
            {
                return;
            }

        }
    }
}
