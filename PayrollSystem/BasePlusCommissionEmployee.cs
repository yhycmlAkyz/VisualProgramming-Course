using System;

namespace PayrollSystem
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;

        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
            : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public decimal BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), value, "Base salary must be >= 0");
                baseSalary = value;
            }
        }

        public override decimal Earnings() => BaseSalary + base.Earnings();

        public override string ToString() =>
            $"base-salaried {base.ToString()}\nbase salary: {BaseSalary:C}";
    }
}