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
        public int Point1 { get; }
        public int Point2 { get; }
        public string Stroka { get; }

        double lengthside;
        /// <summary>
        /// Метод Point
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="stroka">Выбор многоугольника</param>
        public Point(int point1, int point2, string stroka)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Stroka = stroka;
        }
       /// <summary>
       /// Метод расчета длинны стороны
       /// </summary>
       /// <param name="A">Сторона 1</param>
       /// <param name="B">Сторона 2</param>
        public void LengthSide(Point A, Point B)
        {
            double result = (B.Point2 - A.Point1);
            lengthside = result;
        }
        /// <summary>
        /// Метод вывода длинны стороны
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Длинна стороны равна: {lengthside}");
        }
    }
    /// <summary>
    /// Класс фигуры
    /// </summary>
    public class Figure
    {
         
        public double perimetr;
        public int Point1 { get; set; }
        public int Point2 { get; set; }
        public int Point3 { get; set; }
        public int Point4 { get; set; }
        public int Point5 { get; set; }
        /// <summary>
        /// Метод фигуры
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="point3">Точка 3</param>
        public Figure(int point1, int point2, int point3)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Point3 = point3;
        }
        /// <summary>
        /// Метод фигуры
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="point3">Точка 3</param>
        /// <param name="point4">Точка 4</param>
        public Figure(int point1, int point2, int point3, int point4)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Point3 = point3;
            this.Point4 = point4;
        }
        /// <summary>
        /// Метод фигуры
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <param name="point3">Точка 3</param>
        /// <param name="point4">Точка 4</param>
        /// <param name="point5">Точка 5</param>
        public Figure(int point1, int point2, int point3, int point4, int point5)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Point3 = point3;
            this.Point4 = point4;
            this.Point5 = point5;
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
            double result = 0;
            if (Convert.ToInt32(stroka.Stroka) == 3)
            {
                result = Point1 + Point2 + Point3;
            }
            else if (Convert.ToInt32(stroka.Stroka) == 4)
            {
                result = Point1 + Point2 + Point3 + Point4;
            }
            else if (Convert.ToInt32(stroka.Stroka) == 5)
            {
                result = Point1 + Point2 + Point3 + Point4 + Point5;
            }
            perimetr = result;

        }

    }


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
