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
    /// <summary>
    /// Класс поинт
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Точка 1
        /// </summary>
        public int Point1 { get; }
        /// <summary>
        /// Точка 2
        /// </summary>
        public int Point2 { get; }
        /// <summary>
        /// Условие
        /// </summary>
        public string Stroka { get; }

        double lengthside;
        /// <summary>
        /// Конструктор Point
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="stroka">Выбор многоугольника</param>
        public Point(int point1, int point2, string stroka)
        {
            Point1 = point1;
            Point2 = point2;
            Stroka = stroka;
        }
        /// <summary>
        /// Метод расчета длинны стороны
        /// </summary>
        /// <param name="A">Сторона 1</param>
        /// <param name="B">Сторона 2</param>
        public double LengthSide(Point a, Point b) => b.Point2 - a.Point1;

        /// <summary>
        /// Метод вывода длинны стороны
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Длинна стороны равна: {lengthside}");
        }
    }
}
