using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3zad2_v2
{
    public abstract class Pupil
    {
        /// <summary>
        /// Метод учатся, переопределится
        /// </summary>
        public virtual void Study() { }

        /// <summary>
        /// Метод читают, переопределится
        /// </summary>
        public virtual void Read() { }

        /// <summary>
        /// Метод пишут, переопределится
        /// </summary>
        public virtual void Write() { }

        /// <summary>
        /// Метод отдыхают, переопределится
        /// </summary>
        public virtual void Relax() { }

    }
}
