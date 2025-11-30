using System;
using System.Collections.Generic;

namespace NameConnectorApp
{
    class NameConnector
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.WriteLine("Lütfen 10 adet isim giriniz:");
            Console.WriteLine("-----------------------------");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. İsim: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    names.Add(input.ToUpper());
                }
                else
                {
                    names.Add("isim girilmedi");
                }
            }

            Console.WriteLine("\n---------------- SONUÇLAR ----------------");

            names.Sort();
            names.Reverse();

            string descendingNames = string.Join(", ", names);
            Console.WriteLine("\n[Z-A] Azalan Sıralama (Descending):");
            Console.WriteLine(descendingNames);

            names.Reverse();

            string ascendingNames = string.Join(", ", names);
            Console.WriteLine("\n[A-Z] Artan Sıralama (Ascending):");
            Console.WriteLine(ascendingNames);
            Console.ReadLine();
        }
    }
}