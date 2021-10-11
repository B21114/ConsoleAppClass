using System;

namespace ConsoleApp3zad2_v2
{
    /// <summary>
    /// Класс плохие люди, производный от Pupil
    /// </summary>
    class BadPupil : Pupil
    {

        /// <summary>
        /// Переопределенный метод
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Плохие люди");
        }

        /// <summary>
        /// Переопределенный метод
        /// </summary>
        public override void Read()
        {
            Console.WriteLine("Плохие люди");
        }

        /// <summary>
        /// Переопределенный метод
        /// </summary>
        public override void Write()
        {
            Console.WriteLine("Плохие люди");
        }

        /// <summary>
        /// Переопределенный метод
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine("Плохие люди");
        }
    }
}
