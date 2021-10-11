using System;

namespace ConsoleApp3zad2_v2
{

    /// <summary>
    /// Класс лучшие люди, производный от учеников
    /// </summary>
    class ExcelentPupil : Pupil
    {

        /// <summary>
        /// Метод переопределенный учатся
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Лучшие люди");
        }

        /// <summary>
        /// Метод переопределенный читают
        /// </summary>
        public override void Read()
        {
            Console.WriteLine("Лучшие люди");
        }

        /// <summary>
        /// Метод переопределенный пишут
        /// </summary>
        public override void Write()
        {
            Console.WriteLine("Лучшие люди");
        }

        /// <summary>
        /// Метод переопределенный отдыхают
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine("Лучшие люди");
        }
    }
}
