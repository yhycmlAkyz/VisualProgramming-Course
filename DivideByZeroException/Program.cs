using System;

namespace ExceptionHandlingApp
{
    class DivideByZeroTest
    {
        static void Main()
        {
            var continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Lütfen payı giriniz (Tam Sayı): ");
                    var numerator = int.Parse(Console.ReadLine());

                    Console.Write("Lütfen paydayı giriniz (Tam Sayı): ");
                    var denominator = int.Parse(Console.ReadLine());

                    // Bölme işlemi
                    var result = numerator / denominator;

                    Console.WriteLine($"\nSonuç: {numerator} / {denominator} = {result}");
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"\nBİÇİM HATASI: {formatException.Message}");
                    Console.WriteLine("Lütfen sadece tam sayı giriniz.\n");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine($"\nSIFIRA BÖLME HATASI: {divideByZeroException.Message}");
                    Console.WriteLine("Sıfır geçersiz bir paydadır. Lütfen tekrar deneyin.\n");
                }
            } while (continueLoop);

            Console.WriteLine("Program başarıyla tamamlandı.");
            Console.ReadKey();
        }
    }
}