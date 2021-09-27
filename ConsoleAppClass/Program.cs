using System; //Задание 0

namespace ConsoleAppClass
{
    class Program
    {
        class Adress
        {
            public int Index1 { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public int House { get; set; }
            public int Apartment { get; set; }
        }
        static void Main(string[] args)
        {
            Adress adress1 = new Adress()
            {
                Index1 = 123456,
                Country = "Россия",
                City = "Москва",
                Street = "Луговая",
                House = 123,
                Apartment = 13,
            };


          
            Console.WriteLine($"{adress1.Index1} {adress1.Country} {adress1.City} {adress1.Street} {adress1.House} {adress1.Apartment}");

        }
    }
}
