using System;

namespace OOP3
{
    class FileLoggerService : IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
