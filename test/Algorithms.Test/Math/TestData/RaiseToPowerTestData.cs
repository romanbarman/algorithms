using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Test.Math.TestData
{
    public class RaiseToPowerTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 10, 0, 1 };
            yield return new object[] { 10, 1, 10 };
            yield return new object[] { -5, 2, 25 };
            yield return new object[] { 7, 6, 117649 };
            yield return new object[] { -5, 11, -48828125 };
            yield return new object[] { 1, UInt32.MaxValue, 1 };
            yield return new object[] { 2.3, 10, 4142.651121364896 };
            yield return new object[] { -2.2, 9, -1207.2692177920007 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
