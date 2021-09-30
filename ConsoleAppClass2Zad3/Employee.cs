/*Создать класс Employee.
В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
инициализирует поля, соответствующие фамилии и имени сотрудника.
Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
сбор.
Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
оклад и налоговый сбор. */
using System;

namespace ConsoleAppClass2Zad3
{
    /// <summary>
    /// Класс Employee
    /// </summary>
    public class Employee
    {
        private string _fname;
        private string _name;
        private int _stag;
        private double _stagr;
        private int _dolg;
        private double _dolg1;
        private double _oklad;
        private readonly double _nalog = 0.13;
        private string _dolg2;
        /// <summary>
        /// Присвоение переменной результата расчета налога
        /// </summary>
        private double _resultNalog => ResultNalog();
        /// <summary>
        /// Присвоение переменной результата расчета межрасчета
        /// </summary>
        private double _ras4et => Result();

        /// <summary>
        /// КонструкторEmployee 
        /// </summary>
        /// <param name="fname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="stag">Стаж</param>
        /// <param name="dolg">Должность</param>
        /// <param name="oklad">Оклад</param>
        public Employee(string fname, string name, int stag, int dolg, double oklad)
        {
            _fname = fname;
            _name = name;
            _stag = stag;
            _dolg = dolg;
            _oklad = oklad;
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public void Info()
        {
            if (_dolg == 1)
            {
                _dolg2 = "Директор";
                _dolg1 = 100;
            }
            else if (_dolg == 2)
            {
                _dolg2 = "Кирпич";
                _dolg1 = 1;
            }
            else if (_dolg == 3)
            {
                _dolg2 = "Менеджер";
                _dolg1 = 100;
            }


            Console.WriteLine($"Фамилия:{_fname}, Имя:{_name}, Стаж:{_stag}, Должность:{_dolg2}, Оклад:{_oklad},Межрасчет:{_ras4et} Налог:{_resultNalog}");
        }
        /// <summary>
        /// Метод расчета налога
        /// </summary>
        /// <returns>Возвращает результат</returns>
        double ResultNalog() => Result() * _nalog;

        /// <summary>
        ///  Метод расчета межрасчета
        /// </summary>
        /// <returns>Возвращает межрасчет</returns>
        public double Result()
        {
            if (_stag > 10)
            {
                return 1.5 * _dolg * _oklad;
            }
            else if (_stag < 10 && _stag > 5)
            {
                return 1.3 * _dolg * _oklad;
            }
            else if (_stag < 5)
            {
                return 1 * _dolg * _oklad;
            }
            else
                return 1;
        }
    }
}


