using System.Collections;
using System.Collections.Generic;
using Algorithms.Structures;

namespace Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData
{
    public class CopyTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
             yield return new object[] { new UnidirectionalLinkedList<string>(), new string[0] };

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                yield return new object[] { list, new [] { "A" } };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                yield return new object[] { list, new [] { "A", "B" } };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
