using System;
using System.Collections.Generic;

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

        public static Double RaiseToPower(Double number, UInt32 power)
        {
            if (power == 0)
            {
                return 1;
            }

            if (power == 1)
            {
                return number;
            }

            UInt32 workingPower = 1;
            Double result = number;

            while (workingPower * 2 <= power)
            {
                result = result * result;

                if (Double.IsInfinity(result))
                {
                    throw new OverflowException("The result is infinity.");
                }

                if (workingPower > UInt32.MaxValue / 2)
                {
                    break;
                }

                workingPower *= 2;
            }

            return result * RaiseToPower(number, (power - workingPower));
        }

        public static IEnumerable<UInt64> FindFactors(UInt64 number)
        {
            var result = new List<UInt64>();

            if (number <= 1)
            {
                result.Add(number);

                return result;
            }

            while (number % 2 == 0)
            {
                result.Add(2);
                number /= 2;
            }

            UInt64 i = 3;
            var maxFactor = System.Math.Sqrt(number);

            while (i < maxFactor)
            {
                while (number % i == 0)
                {
                    result.Add(i);
                    number /= i;
                    maxFactor = System.Math.Sqrt(number);
                }

                i += 2;
            }

            if (number > 1)
            {
                result.Add(number);
            }

            return result;
        }
    }
}
