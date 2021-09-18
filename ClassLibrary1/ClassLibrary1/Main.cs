using System;

namespace ClassLibrary1
{
    class StartMain
    {
        private static void Main(string[] args)
        {

            //商品ののインスタンス化
            Product product = new Product("どら焼き", 120);

            Console.WriteLine(product.ProductName);

        }
    }
}