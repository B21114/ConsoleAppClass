/*Создать класс Invoice.
В теле класса создать три поля int account, string customer, string provider которые должны
быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
дальнейшего изменения.
В теле класса создать два закрытых поля string article, int quantity
Создать метод расчета стоимости заказа с НДС и без НДС.
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС. */
using System;

namespace ConsoleAppClass2Zad4
{
    /// <summary>
    /// Класс Invoice
    /// </summary>
    public class Invoice
    {
        
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;
        double notnds => this.Calculator();
        double nds => this.CalculatorNDS();
        /// <summary>
        /// Конструктор Invoice
        /// </summary>
        /// <param name="account">Id</param>
        /// <param name="customer">Имя</param>
        /// <param name="provider">Провайдер</param>
        /// <param name="article">Товар</param>
        /// <param name="quantity">Количество товара</param>
        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        /// <summary>
        /// /Метод расчета цены без ндс
        /// </summary>
        /// <returns>Возвращает цену без ндс</returns>
        double Calculator()
        {
            double price;
            if (article == "Samogon")
            {
                price = 150;
            }
            else if (article == "Beer")
            {
                price = 50;
            }
            else
                price = 0;

            double notnds = price * quantity;
            return notnds;
        }
        /// <summary>
        /// Метод расчета цены с ндс
        /// </summary>
        /// <returns>Возвращает цену с ндс</returns>
        double CalculatorNDS()
        {
            double nds = notnds * 1.2;
            return nds;
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public void Info()
        {
            if (nds == 0)
            { Console.WriteLine("Такого продукта нет"); }
            else
            Console.WriteLine($"Id:{account}, Покупатель: {customer}, Провайдер: {provider}, Наименование: {article}, Количество: {quantity}, Цена с ндс: {nds}, Цена: {notnds}");
        }
    }
}
