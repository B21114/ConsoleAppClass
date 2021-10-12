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
        public Pupil()
        {

        }
        public Pupil(string name)
        {
            Name = name;
        }
        public virtual void Study() { }
        public virtual void Read() {}
        public virtual void Write() {}
        public virtual void Relax() {}

        public void Info()
        {
            Console.WriteLine();
        }
    }

    class ExcelentPupil:Pupil
    {
        public ExcelentPupil(string name)
        {
            Name = name;
        }

        public override void Study()
        {
            Console.WriteLine("Лучшие люди учатся");
        }
        public override void Read()
        {
            Console.WriteLine("Лучшие люди пишут");
        }
        public override void Write()
        {
            Console.WriteLine("Лучшие люди читают");
        }
        public override void Relax()
        {
            Console.WriteLine("Лучшие люди отдыхают");
        }
    }
    class GoodPupil : Pupil
    {
        public GoodPupil(string name)
        {
            Name = name;
        }
        public override void Study()
        {
            Console.WriteLine("Хорошие люди учатся");
        }
        public override void Read()
        {
            Console.WriteLine("Хорошие люди пишут");
        }
        public override void Write()
        {
            Console.WriteLine("Хорошие люди читают");
        }
        public override void Relax()
        {
            Console.WriteLine("Лучшие люди отдыхают");
        }
    }
    class BadPupil : Pupil
    {
        public BadPupil(string name)
        {
            Name = name;
        }
        public override void Study()
        {
            Console.WriteLine("Плохие люди учатся");
        }
        public override void Read()
        {
            Console.WriteLine("Плохие люди пишут");
        }
        public override void Write()
        {
            Console.WriteLine("Плохие люди читают");
        }
        public override void Relax()
        {
            Console.WriteLine("Плохие люди отдыхают");
        }
    }
    class ClassRoom
    {
        Random rnd = new Random();
        Pupil[] pupils;

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils = new Pupil[] { pupil1, pupil2};
                for (int i = 0; i < pupils.Length; i++)
                {
                   // pupils[i] = Convert.ToString(rnd.Next());

                }
            }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils = new Pupil[] { pupil1, pupil2, pupil3};
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[] { pupil1, pupil2, pupil3, pupil4 };
        }

        public static void Show()
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil("Алексей");
            Pupil pupil2 = new BadPupil("Владимир");
            Pupil pupil3 = new GoodPupil("Александр");
            Pupil pupil4 = new ExcelentPupil("Григорий");
            var ClassRomm = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        }
    }
}
