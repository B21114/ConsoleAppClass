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
    /// Класс фигуры
    /// </summary>
    public class Figure
    {
         
        private double perimetr;
        /// <summary>
        /// Точка 1
        /// </summary>
        public int Point1 { get; set; }
        /// <summary>
        /// Точка 2
        /// </summary>
        public int Point2 { get; set; }
        /// <summary>
        /// Точка 3
        /// </summary>
        public int Point3 { get; set; }
        /// <summary>
        /// Точка 4
        /// </summary>
        public int Point4 { get; set; }
        /// <summary>
        /// Точка 5
        /// </summary>
        public int Point5 { get; set; }
        /// <summary>
        /// Конструктор фигуры из 3 точек
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="point3">Точка 3</param>
        public Figure(int point1, int point2, int point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }
        /// <summary>
        /// Конструктор фигуры из 4 точек
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="point3">Точка 3</param>
        /// <param name="point4">Точка 4</param>
        public Figure(int point1, int point2, int point3, int point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }
        /// <summary>
        /// Конструктор фигуры из 5 точек
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="point3">Точка 3</param>
        /// <param name="point4">Точка 4</param>
        /// <param name="point5">Точка 5</param>
        public Figure(int point1, int point2, int point3, int point4, int point5)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
            Point5 = point5;
        }
        /// <summary>
        /// Метод вывода периметра 
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Периметр равен: {perimetr}");
        }
      
        /// <summary>
        /// Метод расчета периметра 
        /// </summary>
        /// <param name="stroka">Считываемое условие</param>
        public void PerimeterCalculator(Point stroka)
        {
           
            if (Convert.ToInt32(stroka.Stroka) == 3)
            {
                perimetr = Point1 + Point2 + Point3;
            }
            else if (Convert.ToInt32(stroka.Stroka) == 4)
            {
                perimetr = Point1 + Point2 + Point3 + Point4;
            }
            else if (Convert.ToInt32(stroka.Stroka) == 5)
            {
                perimetr = Point1 + Point2 + Point3 + Point4 + Point5;
            }
            

        }

    }
}
