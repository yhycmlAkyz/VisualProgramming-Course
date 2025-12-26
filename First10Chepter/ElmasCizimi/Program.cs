using System;

namespace ElmasCizimi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int satir = 1; satir <= 5; satir++)
            {

                for (int bosluk = 1; bosluk <= (5 - satir); bosluk++)
                {
                    Console.Write(" ");
                }

                for (int yildiz = 1; yildiz <= (2 * satir) - 1; yildiz++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int satir = 4; satir >= 1; satir--)
            {
                for (int bosluk = 1; bosluk <= (5 - satir); bosluk++)
                {
                    Console.Write(" ");
                }

                for (int yildiz = 1; yildiz <= (2 * satir) - 1; yildiz++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}