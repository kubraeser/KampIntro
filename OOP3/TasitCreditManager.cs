using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredi ödeme planı hesaplandı.");
        }
    }
}
