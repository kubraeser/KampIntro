using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredi ödeme planı hesaplandı.");
        }
    }
}
