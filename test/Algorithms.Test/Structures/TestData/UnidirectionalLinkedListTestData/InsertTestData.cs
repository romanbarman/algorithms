using System.Collections;
using System.Collections.Generic;
using Algorithms.Structures;

namespace Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData
{
    public class InsertTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                var after = list.FindCellBefore("A");
                yield return new object[] { list, after, "B", new [] { "B", "A" } };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                var after = list.FindCell("A");
                yield return new object[] { list, after, "B", new [] { "A", "B" } };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                var after = list.FindCellBefore("B");
                yield return new object[] { list, after, "C", new [] { "A", "C", "B" } };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
