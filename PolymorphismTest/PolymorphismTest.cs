using System;

namespace CommissionApp
{
    class PolymorphismTest
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CommissionEmployee commissionEmployee = new CommissionEmployee(
                "Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee(
                "Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Call CommissionEmployee's ToString and Earnings methods " +
                "with base-class reference to base class object\n");
            Console.WriteLine(commissionEmployee.ToString());
            Console.WriteLine($"earnings: {commissionEmployee.Earnings():C}\n");

            Console.WriteLine("Call BasePlusCommissionEmployee's ToString and " +
                "Earnings methods with derived class reference to derived-class object\n");
            Console.WriteLine(basePlusCommissionEmployee.ToString());
            Console.WriteLine($"earnings: {basePlusCommissionEmployee.Earnings():C}\n");

            CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;

            Console.WriteLine("Call BasePlusCommissionEmployee's ToString and Earnings " +
                "methods with base class reference to derived-class object");

            Console.WriteLine(commissionEmployee2.ToString());

            Console.WriteLine($"earnings: {commissionEmployee2.Earnings():C}");

            Console.ReadKey();
        }
    }
}