using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Test.Math.TestData
{
    public class GcdTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 10, 5, 5 };
            yield return new object[] { 18, 35, 1 };
            yield return new object[] { 28851538, 1183019, 17657 };
            yield return new object[] { 2365, 2365, 2365 };
            yield return new object[] { 90, 84, 6 };
            yield return new object[] { 0, 0, 0 };
            yield return new object[] { 90, 0, 90 };
            yield return new object[] { 0, 85, 85 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
