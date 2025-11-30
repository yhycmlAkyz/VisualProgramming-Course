using System;
using System.Text;

namespace HugeIntegerApp
{
    public class HugeInteger
    {
        private int[] digits = new int[40];
        public void Input(string numberString)
        {
            Array.Clear(digits, 0, digits.Length);

            char[] charArray = numberString.ToCharArray();
            int length = charArray.Length;

            for (int i = 0; i < length; i++)
            {
                if (length <= 40)
                {
                    digits[40 - length + i] = charArray[i] - '0';
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            bool leadingZero = true;

            for (int i = 0; i < 40; i++)
            {
                if (digits[i] != 0)
                {
                    leadingZero = false;
                }

                if (!leadingZero)
                {
                    sb.Append(digits[i]);
                }
            }

            if (sb.Length == 0) return "0";

            return sb.ToString();
        }
        public HugeInteger Add(HugeInteger other)
        {
            HugeInteger result = new HugeInteger();
            int carry = 0;

            for (int i = 39; i >= 0; i--)
            {
                int sum = this.digits[i] + other.digits[i] + carry;
                result.digits[i] = sum % 10;
                carry = sum / 10;
            }

            return result;
        }

        public HugeInteger Subtract(HugeInteger other)
        {
            if (other.IsGreaterThan(this))
            {
                return new HugeInteger();
            }

            HugeInteger result = new HugeInteger();
            int borrow = 0;

            for (int i = 39; i >= 0; i--)
            {
                int sub = this.digits[i] - other.digits[i] - borrow;

                if (sub < 0)
                {
                    sub += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }
                result.digits[i] = sub;
            }

            return result;
        }
        public bool IsZero()
        {
            for (int i = 0; i < 40; i++)
            {
                if (digits[i] != 0) return false;
            }
            return true;
        }

        public bool IsEqualTo(HugeInteger other)
        {
            for (int i = 0; i < 40; i++)
            {
                if (this.digits[i] != other.digits[i]) return false;
            }
            return true;
        }

        public bool IsNotEqualTo(HugeInteger other)
        {
            return !IsEqualTo(other);
        }

        public bool IsGreaterThan(HugeInteger other)
        {
            for (int i = 0; i < 40; i++)
            {
                if (this.digits[i] > other.digits[i]) return true;
                if (this.digits[i] < other.digits[i]) return false;
            }
            return false;
        }

        public bool IsLessThan(HugeInteger other)
        {
            return !IsGreaterThan(other) && !IsEqualTo(other);
        }

        public bool IsGreaterThanOrEqualTo(HugeInteger other)
        {
            return IsGreaterThan(other) || IsEqualTo(other);
        }

        public bool IsLessThanOrEqualTo(HugeInteger other)
        {
            return IsLessThan(other) || IsEqualTo(other);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HugeInteger sayi1 = new HugeInteger();
            HugeInteger sayi2 = new HugeInteger();
            HugeInteger sayi3 = new HugeInteger();

            string val1 = "99999999999999999999";
            string val2 = "1";
            string val3 = "5000";
            string val4 = "2500";

            Console.WriteLine("HUGE INTEGER CLASS TESTİ\n------------------------");

            sayi1.Input(val1);
            sayi2.Input(val2);
            Console.WriteLine($"Sayı 1: {sayi1}");
            Console.WriteLine($"Sayı 2: {sayi2}");

            Console.WriteLine("\n[TOPLAMA TESTİ]");
            HugeInteger toplam = sayi1.Add(sayi2);
            Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");

            sayi1.Input(val3);
            sayi2.Input(val4);
            Console.WriteLine("\n[ÇIKARMA TESTİ]");
            HugeInteger fark = sayi1.Subtract(sayi2);
            Console.WriteLine($"{sayi1} - {sayi2} = {fark}");

            Console.WriteLine("\n[KARŞILAŞTIRMA TESTİ]");
            sayi1.Input("1000");
            sayi2.Input("1000");
            sayi3.Input("500");

            Console.WriteLine($"1000 Eşit mi 1000? : {sayi1.IsEqualTo(sayi2)}");
            Console.WriteLine($"1000 Eşit Değil mi 500? : {sayi1.IsNotEqualTo(sayi3)}");
            Console.WriteLine($"1000 Büyük mü 500? : {sayi1.IsGreaterThan(sayi3)}");
            Console.WriteLine($"500 Küçük mü 1000? : {sayi3.IsLessThan(sayi1)}");
            Console.WriteLine($"0 Sıfır mı? : {new HugeInteger().IsZero()}");

            Console.ReadLine();
        }
    }
}