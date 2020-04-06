using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class IntNumber : Number
    {

        public int Value
        {
            set; get;
        }

        public IntNumber(int value)
        {
            Value = value;
        }

        public IntNumber() : this(0)
        {

        }

        public override long GetDigitsSum()
        {
            int n = Value;
            long sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        public override int GetFirstDigit()
        {
            int i = Value;
            while (i >= 10)
                i /= 10;

            return i;
        }

        public override int GetLastDigit()
        {
            return Value % 10;
        }

        public override string ToString()
        {
            return $"{Value}";
        }

        public static IntNumber operator+(IntNumber n1, IntNumber n2)
        {
            return new IntNumber(n1.Value + n2.Value);
        }
        public static IntNumber operator -(IntNumber n1, IntNumber n2)
        {
            return new IntNumber(n1.Value - n2.Value);
        }
        public static IntNumber operator *(IntNumber n1, IntNumber n2)
        {
            return new IntNumber(n1.Value * n2.Value);
        }
        public static IntNumber operator /(IntNumber n1, IntNumber n2)
        {
            return new IntNumber(n1.Value / n2.Value);
        }
        public static bool operator==(IntNumber n1, IntNumber n2)
        {
            return n1.Value == n2.Value;
        }
        public static bool operator !=(IntNumber n1, IntNumber n2)
        {
            return !(n1.Value == n2.Value);
        }
    }
}
