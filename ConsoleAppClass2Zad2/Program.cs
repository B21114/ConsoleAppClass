/*Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public
Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну */
using System;

namespace ConsoleAppClass2Zad2
{
    public class Converter
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public double uah { get; set; }

        public Converter(double uah)
        {
            this.uah = uah;
        }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;  
        }

        public void Info()
        {
            Console.WriteLine($"Ваши гривны: {uah} = EUR:{eur}, USD:{usd}, RUB:{rub}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Выберите действие: конвертация гривны в евро:1 в доллар:2 в рубли 3");
            Console.WriteLine("Выберите действие: конвертация из евро:4 из доллара:5 из рубля 6");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество гривен");
            Converter converter = new Converter(0.038, 0.032, 2.73);
            Converter converter1 = new Converter(Convert.ToDouble(Console.ReadLine()));
            switch (id)
            {
                case 1:
                    converter1.eur = converter.eur * converter1.uah;
                    converter1.Info();
                    break;
                case 2:
                    converter1.usd = converter.usd * converter1.uah;
                    converter1.Info();
                    break;
                case 3:
                    converter1.rub = converter.rub * converter1.uah;
                    converter1.Info();
                    break;
                case 4:
                    converter.eur = converter1.uah / converter.eur;
                    converter1.Info();
                    break;
                case 5:
                    converter.usd = converter1.uah / converter.usd;
                    converter1.Info();
                    break;
                case 6:
                    converter.rub = converter1.uah / converter.rub;
                    converter1.Info();
                    break;
                default:
                    Console.WriteLine("Повторите ввод");
                    break;
            }
         
           
        }
    }
}
