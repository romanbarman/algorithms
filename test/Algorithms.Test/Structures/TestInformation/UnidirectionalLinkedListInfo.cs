namespace Algorithms.Test.Structures.TestInformation
{
    public class UnidirectionalLinkedListInfo
    {
        public class CellInfo
        {
            public bool IsNull { get; }
            public bool IsValueNull { get; }
            public string Value { get; }
            public bool IsLimiter { get; }

            internal CellInfo(bool isNull, bool isValueNull, string value, bool isLimiter)
            {
                IsNull = isNull;
                IsValueNull = isValueNull;
                Value = value;
                IsLimiter = IsLimiter;
            }
        }

        public CellInfo Expected { get; }
        public CellInfo ExpectedNext { get; }

        internal UnidirectionalLinkedListInfo(CellInfo expected, CellInfo expectedNext)
        {
            Expected = expected;
            ExpectedNext = expectedNext;
        }
    }
}
