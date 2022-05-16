using Algorithms.Structures;
using Algorithms.Test.Structures.TestData.UnidirectionalLinkedListTestData;
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

        private void Equal<T>(UnidirectionalLinkedList<T> list, T[] expectedResult)
        {
            var index = 0;
            foreach (var item in list)
            {
                Assert.Equal(expectedResult[index], item);
                index++;
            }
        }
    }
}
