using System;

    class MaximumFinder
    {
        static void Main()
        {

        double number1, number2, number3, result;

        Console.Write("İlk Sayıyı Gir: ");
        number1 = double.Parse(Console.ReadLine());
        Console.Write("İkinci Sayıyı Gir: ");
        number2 = double.Parse(Console.ReadLine());
        Console.Write("Üçüncü Sayıyı Gir: ");
        number3 = double.Parse(Console.ReadLine());

        result = Maximum(number1, number2, number3);

        Console.WriteLine("En Büyük Sayı: " + result);
        Console.WriteLine("En büyük sayı: " + Math.Max(number1, Math.Max(number2, number3)));

    }

    static double Maximum(double x, double y, double z)
    {
        double max = x;
        if (y > max)
        { 
            max = y;
        }
        if (z > max)
        {
            max = z;
        }
        return max;
    }
}   