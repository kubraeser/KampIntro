using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Kübra Eser";
            customer1.CustomerID = 12345678;
            customer1.CustomerBalanceAccount = 3500;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Nazlı Özer";
            customer2.CustomerID = 87654321;
            customer2.CustomerBalanceAccount = 5000;

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerID + " " +customer.CustomerName + " " + customer.CustomerBalanceAccount);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer1);

            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.AddCustomer(customer2);
            customerManager2.DeleteCustomer(customer2);





        }
    }
}
