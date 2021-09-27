/* Требуется: Создать класс с именем Rectangle.
В теле класса создать два поля, описывающие длины сторон double side1, side2.
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
поля side1 и side2 инициализируются значениями аргументов.
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
прямоугольника - double PerimeterCalculator().
Создать два свойства double Area и double Perimeter с одним методом доступа get.
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
на экран периметр и площадь. */

using System;

namespace ConsoleAppClass1Zad2
{
    public class Rectangle
    {
        public double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Метод рассчета площади
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <returns></returns>
        public double AreaCalculator()
        {
            double resultarea = side1 * side2;
            return resultarea;
        }
        /// <summary>
        /// Метод рассчета периметра
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <returns></returns>
        public double PerimeterCalculator()
        {
            double resultperimetr = (side1 + side2) * 2;
            return resultperimetr;
        }
        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }

        }
        public double Perimetr
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите стороны прямоугольника!");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь: {0}, периметр: {1}", rectangle.Area, rectangle.Perimetr);

        }
    }
}
