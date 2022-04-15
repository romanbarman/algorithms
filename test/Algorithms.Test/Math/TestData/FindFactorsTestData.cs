using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Test.Math.TestData
{
    public class FindFactorsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 0, new List<UInt64> { 0 }};
            yield return new object[] { 1, new List<UInt64> { 1 }};
            yield return new object[] { 2, new List<UInt64> { 2 }};
            yield return new object[] { 3, new List<UInt64> { 3 }};
            yield return new object[] { 4, new List<UInt64> { 2, 2 }};
            yield return new object[] { 17, new List<UInt64> { 17 }};
            yield return new object[] { UInt64.MaxValue, new List<UInt64> { 3, 5, 17, 257, 641, 65537, 6700417 }};
            yield return new object[] { Int32.MaxValue,  new List<UInt64> { Int32.MaxValue }};
            yield return new object[] { 426968651340,  new List<UInt64> { 2, 2, 3, 3, 5, 7, 11, 11, 17, 257, 641}};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
