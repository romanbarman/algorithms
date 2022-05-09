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
            Assert.Equal(expectedResult, Algorithms.Math.Math.FindGcd(a, b));
        }

        [Theory]
        [ClassData(typeof(RaiseToPowerTestData))]
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
