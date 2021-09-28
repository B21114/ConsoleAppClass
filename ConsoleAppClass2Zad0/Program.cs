/*Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
Реализуйте вывод на экран информации о пользователе.*/
using System;

namespace ConsoleAppClass2Zad0
{
    class User
    {
        public string login { get; set; }
        public string name { get; set; }
        public string Fname { get; set; }
        public int age { get; set; }
        public DateTime date { get; set; }
        /// <summary>
        /// Метод Пользователя
        /// </summary>
        /// <param name="l">Логин</param>
        /// <param name="n">Имя</param>
        /// <param name="f">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="d">Дата</param>
        public User(string l, string n, string f, int age, DateTime d)
        {
            login = l;
            name = n;
            Fname = f;
            this.age = age;
            date = d; 
        }
        /// <summary>
        /// метод вывода информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Логин:{login} Имя:{name} Фамилия:{Fname} Возраст:{age} Дата создания:{date}");
        }
        
   
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Leha","Алексей","Бочкарев",27,DateTime.Now);
            user.Info();
        }
    }
}
