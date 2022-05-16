using System.Collections;
using System.Collections.Generic;
using Algorithms.Structures;

namespace Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData
{
    public class DeleteAfterTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                var after = list.FindCellBefore("A");
                yield return new object[] { list, after, new string[0] };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                var after = list.FindCellBefore("A");
                yield return new object[] { list, after, new [] { "B" } };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                var after = list.FindCellBefore("B");
                yield return new object[] { list, after, new [] { "A" } };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
