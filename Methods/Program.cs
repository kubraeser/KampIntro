using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "apple";
            product1.Purchase = 15;
            product1.Explanation = "Amasya apple";

            Product product2 = new Product();
            product2.Name = "watermelon";
            product2.Purchase = 80;
            product2.Explanation = "Diyarbakır watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Purchase);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("---------Methods---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);



        }
    }
}
