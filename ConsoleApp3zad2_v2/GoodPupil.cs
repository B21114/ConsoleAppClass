using System;

namespace ConsoleApp3zad2_v2
{

    /// <summary>
    /// Класс хорошие люди, производный от учеников
    /// </summary>
    class GoodPupil : Pupil
    {

        /// <summary>
        /// Переопределенный метод учатся
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Хорошие люди");
        }

        /// <summary>
        /// Переопределенный метод читают
        /// </summary>
        public override void Read()
        {
            Console.WriteLine("Хорошие люди");
        }

        /// <summary>
        /// Переопределенный метод пишут
        /// </summary>
        public override void Write()
        {
            Console.WriteLine("Хорошие люди");
        }

        /// <summary>
        /// Переопределенный метод отдыхают
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine("Хорошие люди");
        }
    }
}
