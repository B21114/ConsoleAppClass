using System;

namespace ConsoleApp3zad2_v2
{
    /// <summary>
    /// Класс комнаты
    /// </summary>
    class ClassRoom
    {

        /// <summary>
        /// Массив для хранения учеников
        /// </summary>
        Pupil[] _arrPupil;

        /// <summary>
        /// Конструктор для комнаты, с массивом людей
        /// </summary>
        /// <param name="arrPupil">Массив людей</param>
        public ClassRoom(Pupil[] arrPupil)
        {
            this._arrPupil = arrPupil;
        }

        /// <summary>
        /// Метод перебора учеников из массива, которые учатся
        /// </summary>
        public void PrintInfoStudy()
        {
            Console.WriteLine("Учатся: ");
            foreach (Pupil item in _arrPupil)
                item.Study();
        }

        /// <summary>
        /// Метод перебора учеников из массива, которые читают
        /// </summary>
        public void PrintInfoRead()
        {
            Console.WriteLine("Читают: ");
            foreach (Pupil item in _arrPupil)
                item.Read();
        }

        /// <summary>
        /// Метод перебора учеников из массива, которые записывают
        /// </summary>
        public void PrintInfoWrite()
        {
            Console.WriteLine("Записывают: ");
            foreach (Pupil item in _arrPupil)
                item.Write();
        }

        /// <summary>
        /// Метод перебора учеников из массива, которые отдыхают
        /// </summary>
        public void PrintInfoRelax()
        {
            Console.WriteLine("Отдыхают: ");
            foreach (Pupil item in _arrPupil)
                item.Relax();
        }
    }
}
