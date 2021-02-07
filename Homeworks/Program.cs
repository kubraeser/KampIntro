using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "fridge";
            product1.ProductPurschase = 4500;

            Product product2 = new Product();
            product2.ProductName = "oven";
            product2.ProductPurschase = 2000;

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPurschase + " TL " );
            }

            for (int i = 0; i < products.Length ; i++)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].ProductPurschase + " TL ");
            }
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].ProductName + " : " + products[a].ProductPurschase + " TL ");
                a++;
            }
        }
    }
}

class Product
{
    public string ProductName { get; set; }
    public int ProductPurschase { get; set; }
}
