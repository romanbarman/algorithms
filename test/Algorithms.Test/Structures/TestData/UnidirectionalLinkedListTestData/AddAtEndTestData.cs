using System.Collections;
using System.Collections.Generic;
using Algorithms.Structures;

namespace Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData
{
    public class AddAtEndTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
             yield return new object[] { new UnidirectionalLinkedList<string>(), "A", new [] { "A" } };

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                yield return new object[] { list, "B", new [] { "A", "B" } };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtBeginning("A");
                list.AddAtEnd("B");
                yield return new object[] { list, "C", new [] { "A", "B", "C" } };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
