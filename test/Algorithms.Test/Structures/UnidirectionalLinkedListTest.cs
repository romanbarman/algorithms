using System.Linq;
using Algorithms.Structures;
using Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData;
using Algorithms.Test.Structures.TestInformation;
using Xunit;

namespace Algorithms.Test.Structures
{
    public class UnidirectionalLinkedListTest
    {
        [Theory]
        [ClassData(typeof(AddAtBeginningTestData))]
        public void AddAtBeginning_Check(UnidirectionalLinkedList<string> list, string value, string[] expectedResult)
        {
           list.AddAtBeginning(value);

           Equal(list, expectedResult);
        }

        [Theory]
        [ClassData(typeof(AddAtEndTestData))]
        public void AddAtEnd_Check(UnidirectionalLinkedList<string> list, string value, string[] expectedResult)
        {
           list.AddAtEnd(value);

           Equal(list, expectedResult);
        }

        [Theory]
        [ClassData(typeof(InsertTestData))]
        public void Insert_Check(UnidirectionalLinkedList<string> list, UnidirectionalLinkedList<string>.Cell after, string value, string[] expectedResult)
        {
           list.Insert(after, value);

           Equal(list, expectedResult);
        }

        [Theory]
        [ClassData(typeof(DeleteAfterTestData))]
        public void DeleteAfter_Check(UnidirectionalLinkedList<string> list, UnidirectionalLinkedList<string>.Cell after, string[] expectedResult)
        {
           list.DeleteAfter(after);

           if (expectedResult.Length == 0)
           {
                Assert.Empty(list);
           }
           else
           {
                Equal(list, expectedResult);
           }
        }

        [Theory]
        [ClassData(typeof(FindCellTestData))]
        public void FindCell_Check(UnidirectionalLinkedList<string> list, string value, UnidirectionalLinkedListInfo expectedResult)
        {
            var result = list.FindCell(value);

            if (expectedResult.Expected.IsNull)
            {
                Assert.Null(result);
                return;
            }

            if (expectedResult.Expected.IsValueNull)
            {
                Assert.Null(result.Value);
            }
            else
            {
                Assert.Equal(expectedResult.Expected.Value, result.Value);
            }
            Assert.Equal(expectedResult.Expected.IsLimiter, result.IsLimiter);

            if (expectedResult.ExpectedNext.IsNull)
            {
                Assert.Null(result.Next);
                return;
            }

            if (expectedResult.ExpectedNext.IsValueNull)
            {
                Assert.Null(result.Next.Value);
            }
            else
            {
                Assert.Equal(expectedResult.ExpectedNext.Value, result.Next.Value);
            }
            Assert.Equal(expectedResult.ExpectedNext.IsLimiter, result.Next.IsLimiter);
        }

        private void Equal<T>(UnidirectionalLinkedList<T> list, T[] expectedResult)
        {
            var lengthList = list.Count();

            Assert.Equal(expectedResult.Length, lengthList);

            var index = 0;
            foreach (var item in list)
            {
                Assert.Equal(expectedResult[index], item);
                index++;
            }
        }
    }
}
