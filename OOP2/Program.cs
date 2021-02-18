using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.Lastname = "Demiroğ";
            customer1.TcNo = "55555";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567";

            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



            //Gerçek-Tüzel nesneler birbirleri yerine kullanılamaz.(inheritance)

        }
    }
}
