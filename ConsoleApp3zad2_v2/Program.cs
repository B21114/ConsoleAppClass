using System;

namespace ConsoleApp3zad2_v2
{


    class Program
    {
        static void Main()
        {
            Random random = new Random();
            Pupil[] arrPupil = new Pupil[] { new BadPupil(), new GoodPupil(), new ExcelentPupil() };
            /// Рандомные объекты Pupil
            Pupil[] pupil = new Pupil[arrPupil.Length];
            for (int i = 0; i < pupil.Length; i++)
            {
                int j =random.Next(0, 3);
                pupil[i] = arrPupil[j];
            }

            ClassRoom cRoom = new ClassRoom(pupil);

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();

        }
    }
}
