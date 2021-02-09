using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " adına hesap açıldı." + customer.CustomerBalanceAccount + " TL bakiyeniz vardır.");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " hesabınız silinmiştir.");

        }
    }
}