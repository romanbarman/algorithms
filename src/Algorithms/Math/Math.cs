using System;
namespace Algorithms.Math
{
    public static class Math
    {
        public static UInt64 Gcd(UInt64 a, UInt64 b)
        {
            if (a < b)
            {
                var temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                var reminder = a % b;
                a = b;
                b = reminder;
            }

            return a;
        }

        public static Double RaiseToPower(Double a, UInt32 b)
        {
            if (b == 0)
            {
                return 1;
            }

            if (b == 1)
            {
                return a;
            }

            UInt32 power = 1;
            Double result = a;

            while (power * 2 <= b)
            {
                result = result * result;

                if (Double.IsInfinity(result))
                {
                    throw new OverflowException("The result is infinity.");
                }

                if (power > UInt32.MaxValue / 2)
                {
                    break;
                }

                power *= 2;
            }

            return result * RaiseToPower(a, (b - power));
        }
    }
}