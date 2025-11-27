using System;

namespace DunyaNufusArtisi
{
    class Program
    {
        static void Main(string[] args)
        {
            double nufus = 8200000000;
            double artisOrani = 0.009;
            double yillikArtisMiktari = 0;

            double baslangicNufusu = nufus;
            int ikiKatinaCiktigiYil = 0;
            bool ikiKatBulundu = false;

            Console.WriteLine("DÜNYA NÜFUS ARTIŞ SİMÜLASYONU (Gelecek 75 Yıl)");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine("{0,-10} {1,-25} {2,-25}", "Yıl", "Yıl Sonu Nüfus", "Sayısal Artış");
            Console.WriteLine("-----------------------------------------------------------------------");

            for (int yil = 1; yil <= 75; yil++)
            {

                yillikArtisMiktari = nufus * artisOrani;

                nufus = nufus + yillikArtisMiktari;

                Console.WriteLine("{0,-10} {1,-25:F0} {2,-25:F0}",
                    yil,
                    nufus,
                    yillikArtisMiktari);

                // Eğer nüfus başlangıcın 2 katını geçtiyse ve daha önce bulmadıysak
                if (nufus >= (baslangicNufusu * 2) && ikiKatBulundu == false)
                {
                    ikiKatinaCiktigiYil = yil;
                    ikiKatBulundu = true;
                }
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            // Sonuç Raporu
            if (ikiKatBulundu)
            {
                Console.WriteLine("\nSONUÇ: Nüfus " + ikiKatinaCiktigiYil + ". yılda başlangıç değerinin iki katına ulaştı.");
            }
            else
            {
                Console.WriteLine("\nSONUÇ: 75 yıl içinde nüfus iki katına ulaşmadı.");
            }

            Console.ReadLine();
        }
    }
}