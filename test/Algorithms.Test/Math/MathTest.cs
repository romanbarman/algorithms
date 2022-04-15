using System;
using System.Collections.Generic;
using Algorithms.Test.Math.TestData;
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

        [Theory]
        [InlineData(10, 0, 1)]
        [InlineData(10, 1, 10)]
        [InlineData(-5, 2, 25)]
        [InlineData(7, 6, 117649)]
        [InlineData(-5, 11, -48828125)]
        [InlineData(1, UInt32.MaxValue, 1)]
        [InlineData(2.3, 10, 4142.651121364896)]
        [InlineData(-2.2, 9, -1207.2692177920007)]
        public void RaiseToPower_Check(Double a, UInt32 b, Double result)
        {
            Assert.Equal(result, Algorithms.Math.Math.RaiseToPower(a, b));
        }

        [Fact]
        public void RaiseToPower_Throw_Overflow_Exception()
        {
            Assert.Throws<OverflowException>(() => Algorithms.Math.Math.RaiseToPower(Double.MaxValue, 2));
        }

        [Theory]
        [ClassData(typeof(FindFactorsTestData))]
        public void FindFactors_Check(UInt64 number, IEnumerable<UInt64> expectedResult)
        {
            Assert.Equal(expectedResult, Algorithms.Math.Math.FindFactors(number));
        }
    }
}
