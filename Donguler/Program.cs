using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kampı";
            string kurs2 = "programlamaya başlama kursu";
            string kurs3 = "java kursu";

            //array
            string[] kurslar = new string[] { "yazılım geliştirici kampı" , "programlamaya başlama kursu" ,
                "java kursu" , "python" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
