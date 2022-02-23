using System;
using Xunit;

namespace Algorithms.Test.Math
{
    public class MathTest
    {
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(18, 35, 1)]
        [InlineData(28851538, 1183019, 17657)]
        [InlineData(2365, 2365, 2365)]
        [InlineData(90, 84, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(90, 0, 90)]
        [InlineData(0, 85, 85)]
        public void Gcd_Check(UInt64 a, UInt64 b, UInt64 result)
        {
            Assert.Equal(result, Algorithms.Math.Math.Gcd(a, b));
        }
    }
}