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
    }
}