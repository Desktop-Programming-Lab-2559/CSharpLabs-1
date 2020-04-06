using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class RealNumber : Number
    {
        public double Value { get; set; }

        public RealNumber(double value)
        {
            Value = value;
        }

        public RealNumber() : this(0.0)
        {

        }

        public override long GetDigitsSum()
        {
            long sum = 0;
            string str_value = $"{Value}";

            for (int i = 0; i < str_value.Length; i++)
            {
                if (str_value[i] == ',') continue;
                sum += str_value[i] - '0';
            }

            return sum;
        }

        public override int GetFirstDigit()
        {
            return Convert.ToInt32($"{Value}"[0] - '0');
        }

        public override int GetLastDigit()
        {
            return Convert.ToInt32($"{Value}"[$"{Value}".Length-1] - '0');
        }

        public override string ToString()
        {
            return $"{Value}";
        }

        public static RealNumber operator +(RealNumber n1, RealNumber n2)
        {
            return new RealNumber(n1.Value + n2.Value);
        }
        public static RealNumber operator -(RealNumber n1, RealNumber n2)
        {
            return new RealNumber(n1.Value - n2.Value);
        }
        public static RealNumber operator *(RealNumber n1, RealNumber n2)
        {
            return new RealNumber(n1.Value * n2.Value);
        }
        public static RealNumber operator /(RealNumber n1, RealNumber n2)
        {
            return new RealNumber(n1.Value / n2.Value);
        }
        public static bool operator==(RealNumber n1, RealNumber n2)
        {
            return Math.Abs(n1.Value - n2.Value) < double.Epsilon;
        }
        public static bool operator !=(RealNumber n1, RealNumber n2)
        {
            return !(n1 == n2);
        }
    }
}
