/*Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
Реализуйте вывод на экран информации о пользователе.*/
using System;

namespace ConsoleAppClass2Zad0
{
    class User
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
       /// <summary>
       /// Фамилия
       /// </summary>
        public string Fname { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; }
        /// <summary>
        ///  Метод Пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="name">Имя</param>
        /// <param name="fname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="date">Дата</param>
        public User(string login, string name, string fname, int age, DateTime date)
        {
            Login = login;
            Name = name;
            Fname = fname;
            Age = age;
            Date = date; 
        }
        /// <summary>
        /// метод вывода информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Логин:{Login} Имя:{Name} Фамилия:{Fname} Возраст:{Age} Дата создания:{Date}");
        }
        
   
    }
}
