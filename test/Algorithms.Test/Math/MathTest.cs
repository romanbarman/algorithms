using System;
using System.Collections.Generic;
using Algorithms.Test.Math.TestData;
using Xunit;

namespace Algorithms.Test.Math
{
    public class MathTest
    {
        [Theory]
        [ClassData(typeof(GcdTestData))]
        public void Gcd_Check(UInt64 a, UInt64 b, UInt64 expectedResult)
        {
            Assert.Equal(expectedResult, Algorithms.Math.Math.Gcd(a, b));
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
        public void RaiseToPower_Check(Double number, UInt32 power, Double expectedResult)
        {
            Assert.Equal(expectedResult, Algorithms.Math.Math.RaiseToPower(number, power));
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
