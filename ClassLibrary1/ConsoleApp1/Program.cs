using System;

using ProductClass;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //商品ののインスタンス化
            Product product = new Product("どら焼き", 120);
            //消費税
            double taxValue;

            taxValue = product.TaxManeger(product.ProductPrice);

            Console.WriteLine(product.ProductName + " " +taxValue);
            
        }
    }
}
