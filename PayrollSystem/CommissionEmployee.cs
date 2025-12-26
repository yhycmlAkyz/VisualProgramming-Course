using System;

namespace PayrollSystem
{
    public class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private decimal commissionRate;

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public decimal GrossSales
        {
            get { return grossSales; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), value, "Gross sales must be >= 0");
                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get { return commissionRate; }
            set
            {
                if (value <= 0 || value >= 1) throw new ArgumentOutOfRangeException(nameof(value), value, "Commission rate must be > 0 and < 1");
                commissionRate = value;
            }
        }

        public override decimal Earnings() => CommissionRate * GrossSales;

        public override string ToString() =>
            $"commission employee: {base.ToString()}\ngross sales: {GrossSales:C}\ncommission rate: {CommissionRate:F2}";
    }
}