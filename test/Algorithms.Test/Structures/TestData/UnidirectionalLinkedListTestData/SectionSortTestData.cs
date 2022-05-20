using System.Collections;
using System.Collections.Generic;
using Algorithms.Structures;

namespace Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData
{
    public class SectionSortTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
             yield return new object[] { new UnidirectionalLinkedList<int>(), new int[0] };

            {
                var list = new UnidirectionalLinkedList<int>();
                list.AddAtEnd(1);
                yield return new object[] { list, new [] { 1 } };
            }

            {
                var list = new UnidirectionalLinkedList<int>();
                list.AddAtEnd(5);
                list.AddAtEnd(2);
                list.AddAtEnd(2);
                list.AddAtEnd(3);
                list.AddAtEnd(5);
                list.AddAtEnd(1);
                list.AddAtEnd(4);
                yield return new object[] { list, new [] { 1, 2, 2, 3, 4, 5, 5 } };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
