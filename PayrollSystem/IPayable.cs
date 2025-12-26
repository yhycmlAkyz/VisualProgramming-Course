using System;

namespace PayrollSystem
{
    public interface IPayable
    {
        decimal GetPaymentAmount();
    }
}