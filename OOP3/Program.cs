using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();

            ICreditManager tasitCreditManager = new TasitCreditManager();

            ICreditManager konutCreditManager = new KonutCreditManager();

            IloggerService dataBaseLoggerService = new DataBaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager() , new List<IloggerService>(){dataBaseLoggerService, fileLoggerService
            , new SmsLoggerService()});


            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacCreditManager, tasitCreditManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
