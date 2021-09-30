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
    class Employee
    {
        private string fname;
        private string name;
        private int stag;
        private double stagr;
        private int dolg;
        private double dolg1;
        private double oklad;
        private readonly double nalog = 0.13;
        private string Dolg;
        private double resultNalog => this.Nalog();
        private double ras4et=> this.Result();

        public Employee(string fname, string name, int stag, int dolg, double oklad)
        {
            this.fname = fname;
            this.name = name;
            this.stag = stag;
            this.dolg = dolg;
            this.oklad = oklad;
        }
        public void Info()
        {
            if (dolg == 1)
            {
                Dolg = "Директор";
                dolg1 = 100;
            }
            else if (dolg == 2)
            {
                Dolg = "Кирпич";
                dolg1 = 1;
            }
            else if (dolg == 3)
            {
                Dolg = "Менеджер";
                dolg1 = 100;
            }

            Console.WriteLine($"Фамилия:{fname}, Имя:{name}, Стаж:{stag}, Должность:{Dolg}, Оклад:{oklad},Межрасчет:{ras4et} Налог:{resultNalog}");
        }
          public double Result()
         {
            if (stag > 10)
            {
                stagr = 1.5;
            }
            else if (stag < 10 && stag > 5)
            {
                stagr = 1.3;
            }
            else
            {
                stagr = 1;
            }
              double  ras4et = stagr * dolg * oklad ;
            
               return ras4et;
           }
        public double Nalog()
        {
           double  resultNalog = ras4et * nalog;
            return resultNalog;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Бочкарев", "Алексей", 10, 1, 1000);
            Employee employee2 = new Employee("Кирпичев", "Кирпич", 1, 2, 100);
            Employee employee3 = new Employee("Володина", "Кира", 13, 3, 10000);
            employee1.Info();
            employee2.Info();
            employee3.Info();
            
        }
    }
}
