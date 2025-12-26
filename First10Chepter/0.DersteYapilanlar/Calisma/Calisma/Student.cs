using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ogrenci
    {
        static void Main()
        {
            Student student1 = new Student("Yahya Cemal", 100);
            Student student2 = new Student("sa", 10);

        Console.WriteLine($"{student1.Name} notu: {student1.Average}, harf notu: {student1.LetterGarde}");
        Console.WriteLine($"{student2.Name} notu: {student2.Average}, harf notu: {student2.LetterGarde}");
    }
}
