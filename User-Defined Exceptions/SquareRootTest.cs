using System;

namespace ExceptionHandlingApp
{
    class SquareRootTest
    {
        static void Main()
        {
            var continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Karekökünü almak için bir sayı girin: ");
                    double inputValue = double.Parse(Console.ReadLine());

                    double result = SquareRoot(inputValue);

                    Console.WriteLine($"Karekök({inputValue}) = {result:F6}\n");
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"\n{formatException.Message}");
                    Console.WriteLine("Lütfen geçerli bir sayı girin.\n");
                }
                catch (NegativeNumberException negativeNumberException)
                {
                    Console.WriteLine($"\n{negativeNumberException.Message}");
                    Console.WriteLine("Lütfen negatif olmayan bir sayı girin.\n");
                }
            } while (continueLoop);

            Console.ReadKey();
        }

        public static double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new NegativeNumberException("Negatif sayıların karekökü alınamaz.");
            }

            return Math.Sqrt(value);
        }
    }
}