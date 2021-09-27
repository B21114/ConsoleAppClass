using System; //Задание 0

namespace ConsoleAppClass
{
    class Program
    {
        class Adress
        {
            public int Index { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public int House { get; set; }
            public int Apartment { get; set; }
        }
        static void Main(string[] args)
        {
            Adress adress1 = new Adress();
            adress1.Index = 123456;
            adress1.Country = "Россия";
            adress1.City = "Москва";
            adress1.Street = "Луговая";
            adress1.House = 123;
            adress1.Apartment = 13;

            Console.WriteLine($"{adress1.Index} {adress1.Country} {adress1.City} {adress1.Street} {adress1.House} {adress1.Apartment}");

        }
    }
}
