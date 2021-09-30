/*Создать класс Invoice.
В теле класса создать три поля int account, string customer, string provider которые должны
быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
дальнейшего изменения.
В теле класса создать два закрытых поля string article, int quantity
Создать метод расчета стоимости заказа с НДС и без НДС.
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС. */

namespace ConsoleAppClass2Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(1, "Leha", "MTS", "Beer", 100);
            Invoice invoice2 = new Invoice(2, "Dima", "Megafon", "Samogon", 20);
            Invoice invoice3 = new Invoice(2, "Ema", "Lutic", "Vodka", 10);

            invoice1.Info();
            invoice2.Info();
            invoice3.Info();

        }
    }
}
