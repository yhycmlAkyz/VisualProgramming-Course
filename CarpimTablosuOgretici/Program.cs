using System;

namespace CarpimTablosuOgretici
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("--- ÇARPIM TABLOSU ÖĞRETİCİSİ ---");
            Console.WriteLine("Çıkış yapmak için 'exit' yazabilirsiniz veya pencereyi kapatabilirsiniz.\n");

            while (true)
            {
                SoruSor();
            }
        }

        static void SoruSor()
        {
            int sayi1 = random.Next(1, 10);
            int sayi2 = random.Next(1, 10);
            int dogruCevap = sayi1 * sayi2;

            bool bildiMi = false;

            while (!bildiMi)
            {
                Console.Write($"{sayi1} kere {sayi2} kaçtır? ");
                string giris = Console.ReadLine();

                if (giris.ToLower() == "exit" || giris.ToLower() == "çıkış")
                {
                    Environment.Exit(0);
                }

                if (int.TryParse(giris, out int ogrenciCevabi))
                {
                    if (ogrenciCevabi == dogruCevap)
                    {
                        Console.WriteLine("Çok iyi!\n");
                        bildiMi = true;
                    }
                    else
                    {
                        Console.WriteLine("Hayır. Lütfen tekrar deneyin.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin.");
                }
            }
        }
    }
}