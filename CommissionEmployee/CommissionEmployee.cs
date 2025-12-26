using System;

namespace CommissionApp
{
    class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Test Başlıyor ---\n");

            var employee = new CommissionEmployee("Sue", "Jones",
                "222-22-2222", 10000.00M, .06M);

            Console.WriteLine("Employee information obtained by properties and methods:\n");
            Console.WriteLine($"First name is {employee.FirstName}");
            Console.WriteLine($"Last name is {employee.LastName}");
            Console.WriteLine($"Gross sales are {employee.GrossSales:C}");
            Console.WriteLine($"Earnings are {employee.Earnings():C}");

            Console.WriteLine("\nUpdating information...");
            employee.GrossSales = 5000.00M;
            employee.CommissionRate = .1M;

            Console.WriteLine("\nUpdated employee information obtained by ToString:\n");
            Console.WriteLine(employee);
            Console.WriteLine($"Earnings: {employee.Earnings():C}");

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}