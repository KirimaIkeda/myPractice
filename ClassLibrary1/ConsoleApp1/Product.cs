using System;

namespace ProductClass
{
    public class Product
    {
        /// <summary>商品名</summary>
        public string ProductName { get; set; }

        /// <summary>商品値段</summary>
        public int ProductPrice { get; set; }

        /// <summary>消費税を含む値段</summary>
        public double IncludeTaxProductPrice
        {
            get
            {
                return IncludeTaxProductPrice;
            }

            set
            {
                IncludeTaxProductPrice = this.ProductPrice + this.TaxManeger(ProductPrice);
            }
        }

        /// <summary>消費税</summary>
        const double Tax = 0.1;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="productName">商品名</param>
        /// <param name="productPrice">商品値段</param>
        public Product(string productName , int productPrice )
        {
            this.ProductName = productName;

            this.ProductPrice = productPrice;
        }

        /// <summary>
        /// 消費税を求めるメソッド
        /// </summary>
        /// <param name="intPrice">商品代</param>
        /// <returns></returns>
        public double TaxManeger(int intPrice)
        {

            return intPrice * Tax;

        }

    }
}
