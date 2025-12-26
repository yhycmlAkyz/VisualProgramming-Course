using System;

namespace ButceAnalizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- TASARRUF ORANI HESAPLAYICI ---");

            Console.Write("Lütfen Aylık Gelirinizi Girin: ");
            double gelir = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen Aylık Giderlerinizi Girin: ");
            double gider = Convert.ToDouble(Console.ReadLine());

            double aylikTasarruf = gelir - gider;

            double tasarrufOrani = aylikTasarruf / gelir;

            Console.WriteLine("\n---------------- SONUÇLAR ----------------");
            Console.WriteLine("Aylık Tasarruf Miktarı: " + aylikTasarruf);

            Console.WriteLine("Tasarruf Oranı: " + tasarrufOrani.ToString("P"));
            Console.WriteLine("------------------------------------------");

            Console.Write("Analiz Sonucu: ");

            if (tasarrufOrani < 0.20)
            {
                Console.WriteLine("Savurgan veya Düşük Tasarruf");
                Console.WriteLine("Yorum: Harcamalarınıza biraz dikkat etmeniz gerekebilir.");
            }
            else if (tasarrufOrani >= 0.20 && tasarrufOrani < 0.40)
            {
                Console.WriteLine("Daha Az Savurgan veya Orta Düzeyde Tasarruf");
                Console.WriteLine("Yorum: Fena değil, dengeli bir bütçeniz var.");
            }
            else if (tasarrufOrani >= 0.40 && tasarrufOrani < 0.75)
            {
                Console.WriteLine("Canlı veya Güçlü Tasarruf");
                Console.WriteLine("Yorum: Harika! Geleceğiniz için çok iyi yatırım yapıyorsunuz.");
            }
            else
            {
                Console.WriteLine("Cimri veya Tasarruf Delisi");
                Console.WriteLine("Yorum: İnanılmaz bir oran! Ama yaşamayı da unutmayın :)");
            }

            Console.ReadLine();
        }
    }
}