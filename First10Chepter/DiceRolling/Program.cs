using System;

public class DiceRolling
{
    public static void Main(string[] args)
    {

        Random random = new Random();

        int[] frequency = new int[13];

        int rolls = 36000;

        for (int i = 0; i < rolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            int sum = die1 + die2;

            frequency[sum]++;
        }

        Console.WriteLine("{0,-10}{1,-15}{2,-20}{3,-20}", "Toplam", "Gelme Sayısı", "Gerçekleşen(%)", "Beklenen(%)*");
        Console.WriteLine(new string('-', 65));

        for (int face = 2; face <= 12; face++)
        {
            double actualPercent = (double)frequency[face] / rolls * 100;
            double expectedPercent = GetExpectedProbability(face);

            Console.WriteLine("{0,-10}{1,-15}{2,-20:F2}{3,-20:F2}",
                face,
                frequency[face],
                actualPercent,
                expectedPercent);
        }

        Console.WriteLine("\n* Zar atılmış ve gelmesi gerekenle zardan gelenler karşılaştırılmıştır");
        Console.ReadLine();
    }
    private static double GetExpectedProbability(int sum)
    {
        int combinations = 0;

        if (sum <= 7)
            combinations = sum - 1;
        else
            combinations = 13 - sum;

        return (double)combinations / 36 * 100;
    }
}