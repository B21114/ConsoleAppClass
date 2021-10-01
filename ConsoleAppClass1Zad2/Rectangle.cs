/* Требуется: Создать класс с именем Rectangle.
В теле класса создать два поля, описывающие длины сторон double side1, side2.
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
поля side1 и side2 инициализируются значениями аргументов.
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
прямоугольника - double PerimeterCalculator().
Создать два свойства double Area и double Perimeter с одним методом доступа get.
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
на экран периметр и площадь. */

namespace ConsoleAppClass1Zad2
{
    /// <summary>
    /// Класс подсчета периметра, площади
    /// </summary>
    public class Rectangle
    {
        private readonly double _side1, _side2;
        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="side1"> Ширина</param>
        /// <param name="side2"> Длина</param>
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }
        /// <summary>
        /// Метод подсчета площади
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator() => _side1 * _side2;

        /// <summary>
        /// Метод подсчета периметра
        /// </summary>
        /// <returns></returns>
        public double PerimeterCalculator() => (_side1 + _side2) * 2;

        /// <summary>
        /// Передача значения площади
        /// </summary>
        public double Area => AreaCalculator();

        /// <summary>
        /// Передача значения периметра
        /// </summary>
        public double Perimetr => PerimeterCalculator();

    }
}
