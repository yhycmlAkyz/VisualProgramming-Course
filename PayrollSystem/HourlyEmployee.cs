using System;

namespace PayrollSystem
{
    public class HourlyEmployee : Employee
    {
        private decimal wage;
        private decimal hours;

        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, decimal wage, decimal hours)
            : base(firstName, lastName, socialSecurityNumber)
        {
            Wage = wage;
            Hours = hours;
        }

        public decimal Wage
        {
            get { return wage; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), value, "Wage must be >= 0");
                wage = value;
            }
        }

        public decimal Hours
        {
            get { return hours; }
            set
            {
                if ((value < 0) || (value > 168))
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Hours must be >= 0 and <= 168");
                hours = value;
            }
        }

        public override decimal Earnings()
        {
            if (Hours <= 40)
                return Wage * Hours;
            else 
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }

        public override string ToString() =>
            $"hourly employee: {base.ToString()}\nhourly wage: {Wage:C}\nhours worked: {Hours:F2}";
    }
}