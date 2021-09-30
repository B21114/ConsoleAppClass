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
        
        readonly int _account;
        readonly string _customer;
        readonly string _provider;
        string _article;
        int _quantity;
        double _notnds => Calculator();
        double _nds => CalculatorNDS();
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
            _account = account;
            _customer = customer;
            _provider = provider;
            _article = article;
            _quantity = quantity;
        }
        /// <summary>
        /// /Метод расчета цены без ндс
        /// </summary>
        /// <returns>Возвращает цену без ндс</returns>
        double Calculator()
        {
            if (_article == "Samogon")
            {
                return 150 * _quantity;
            }
            else if (_article == "Beer")
            {
                return 50 * _quantity;
            }
            else
                return 0;
     
        }
        /// <summary>
        /// Метод расчета цены с ндс
        /// </summary>
        /// <returns>Возвращает цену с ндс</returns>
        double CalculatorNDS()=> _notnds * 1.2;
        
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public void Info()
        {
            if (_nds == 0)
            { Console.WriteLine("Такого продукта нет"); }
            else
            Console.WriteLine($"Id:{_account}, Покупатель: {_customer}, Провайдер: {_provider}, Наименование: {_article}, Количество: {_quantity}, Цена с ндс: {_nds}, Цена: {_notnds}");
        }
    }
}
