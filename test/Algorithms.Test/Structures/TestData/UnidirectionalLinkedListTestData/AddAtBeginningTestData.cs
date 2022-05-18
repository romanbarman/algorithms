using System.Collections;
using System.Collections.Generic;
using Algorithms.Structures;

namespace Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData
{
    public class AddAtBeginningTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
             yield return new object[] { new UnidirectionalLinkedList<string>(), "A", new [] { "A" } };

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtBeginning("A");
                yield return new object[] { list, "B", new [] { "B", "A" } };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtBeginning("A");
                list.AddAtEnd("B");
                yield return new object[] { list, "C", new [] { "C", "A", "B" } };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
