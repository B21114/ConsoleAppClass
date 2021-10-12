/*
Создайте класс Printer.
В теле класса создайте метод void Print(string value), который выводит на экран значение
аргумента.
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
выводились разными цветами.
Обязательно используйте приведение типов. */

namespace ConsoleApp3Zad0
{


    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Строка1");
            Red red = new Red();
            red.Print("Строка2");
            Green green = new Green();
            green.Print("Строка3");
        }
    }
}
