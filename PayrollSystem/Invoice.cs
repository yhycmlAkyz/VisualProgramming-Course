using System;

namespace PayrollSystem
{
    public class Invoice : IPayable
    {
        public string PartNumber { get; }
        public string PartDescription { get; }
        private int quantity;
        private decimal pricePerItem;

        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), value, "Quantity must be >= 0");
                quantity = value;
            }
        }

        public decimal PricePerItem
        {
            get { return pricePerItem; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), value, "Price per item must be >= 0");
                pricePerItem = value;
            }
        }

        public override string ToString() =>
            $"invoice:\npart number: {PartNumber} ({PartDescription})\n" +
            $"quantity: {Quantity}\nprice per item: {PricePerItem:C}";

        public decimal GetPaymentAmount() => Quantity * PricePerItem;
    }
}