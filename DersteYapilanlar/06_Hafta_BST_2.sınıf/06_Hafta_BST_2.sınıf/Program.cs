using System;
using System.Linq;

class LINQWithSimpleTypeArray
{

    static void Main()
    {
        var values = new int[] { 2,9,5,0,3,7,1,4,8,5 };
        Console.WriteLine("Original array: ");
        foreach (var element in values)
        {
            Console.Write($" {element}");
        }

        var filtered = from value in values
        where value > 4
        select value;

        Console.WriteLine("\n\nFiltered array (values > 4): ");
        foreach (var element in filtered)
        {
            Console.Write($" {element}");
        }

        var sorted = from value in values
        orderby value
        select value;

        Console.WriteLine("\n\nSorted array: ");
        foreach (var element in sorted)
        {
            Console.Write($" {element}");
        }

        var sortedFiltered = from value in filtered
        orderby value descending
        select value;

        Console.WriteLine("\n\nSorted filtered array (values > 4 in descending order): ");
        foreach (var element in sortedFiltered)
        {
            Console.Write($" {element}");
        }

    }

}