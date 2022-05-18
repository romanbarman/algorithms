using System.Collections;
using System.Collections.Generic;
using Algorithms.Structures;
using Algorithms.Test.Structures.TestInformation;

namespace Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData
{
    public class FindCellTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                list.AddAtEnd("C");

                var expectedCell = new UnidirectionalLinkedListInfo.CellInfo(false, false, "A", false);
                var expectedNextCell = new UnidirectionalLinkedListInfo.CellInfo(false, false, "B", false);
                var expectedResult = new UnidirectionalLinkedListInfo(expectedCell, expectedNextCell);
                yield return new object[] { list, "A", expectedResult };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                list.AddAtEnd("C");

                var expectedCell = new UnidirectionalLinkedListInfo.CellInfo(false, false, "B", false);
                var expectedNextCell = new UnidirectionalLinkedListInfo.CellInfo(false, false, "C", false);
                var expectedResult = new UnidirectionalLinkedListInfo(expectedCell, expectedNextCell);
                yield return new object[] { list, "B", expectedResult };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                list.AddAtEnd("C");

                var expectedCell = new UnidirectionalLinkedListInfo.CellInfo(false, false, "C", false);
                var expectedNextCell = new UnidirectionalLinkedListInfo.CellInfo(true, true, null, false);
                var expectedResult = new UnidirectionalLinkedListInfo(expectedCell, expectedNextCell);
                yield return new object[] { list, "C", expectedResult };
            }

            {
                var list = new UnidirectionalLinkedList<string>();
                list.AddAtEnd("A");
                list.AddAtEnd("B");
                list.AddAtEnd("C");

                var expectedCell = new UnidirectionalLinkedListInfo.CellInfo(true, true, null, false);
                var expectedResult = new UnidirectionalLinkedListInfo(expectedCell, null);
                yield return new object[] { list, "D", expectedResult };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
