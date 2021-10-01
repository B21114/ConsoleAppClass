/*Создать класс, представляющий учебный класс ClassRoom.
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax().
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
писать, отдыхать.*/

using System;

namespace ConsoleApp3zad2
{
    class Pupil
    {
        public string Name { get; set; }
        public string Fname { get; set; }
        public double Ocenki { get; set; }
        public double Povedenie { get; set; }
        public Pupil()
        { }
        void Study() {
            Console.WriteLine("Учится"); 
        }
        void Read() {
            Console.WriteLine("Читает");
        }
        void Write() {
            Console.WriteLine("Пишет");
        }
        void Relax() {
            Console.WriteLine("Отдыхает");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         //   Pupil pupil = new Pupil("1","2",3,4);
        
        }
    }
}
