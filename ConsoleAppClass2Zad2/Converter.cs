/*Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public
Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну */
using System;

namespace ConsoleAppClass2Zad2
{
    /// <summary>
    /// Класс конвертер
    /// </summary>
    public class Converter
    {
       
        /// <summary>
        /// Доллар
        /// </summary>
        public double Usd { get; set; }
        
        /// <summary>
        /// Евро
        /// </summary>
        public double Eur { get; set; }
        
        /// <summary>
        /// Рубли
        /// </summary>
        public double Rub { get; set; }
       
        /// <summary>
        /// Гривны
        /// </summary>
        public double Uah { get; set; }

        /// <summary>
        /// Конструктор гривны
        /// </summary>
        /// <param name="uah"></param>
        public Converter(double uah)
        {
            Uah = uah;
        }
        
        /// <summary>
        /// Конструтор с евро, долларом и рублем
        /// </summary>
        /// <param name="usd">Доллар</param>
        /// <param name="eur">Евро</param>
        /// <param name="rub">Рубли</param>
        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;  
        }
        
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Ваши гривны: {Uah} = EUR:{Eur}, USD:{Usd}, RUB:{Rub}");
        }

    }
}
