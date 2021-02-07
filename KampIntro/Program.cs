using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            string KategoriEtiketi = "Kategori";
            int OgrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;

            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (DolarDun < DolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(KategoriEtiketi);
        }
    }
}
