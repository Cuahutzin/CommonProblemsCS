using Core.Exercise04;
using NUnit.Framework;

namespace Core.Tests.Exercise04
{
    [TestFixture]
    public class DataProviderTests
    {
        [Test]
        [TestCase("TestFiles/DataProviderTestFile_OK_EmptyFile.txt")]
        [TestCase("TestFiles/DataProviderTestFile_OK_MultipleLinesBarelyOneNumberEach.txt")]
        [TestCase("TestFiles/DataProviderTestFile_OK_MultipleLinesOneNumberEach.txt")]
        public void GetIntegers_WhenCalled_Return(string filepath, long[] expectedResult)
        {
            var dataProvider = new DataProvider(filepath);
            var result = dataProvider.GetIntegers();
            CollectionAssert.AreEquivalent(expectedResult, result);
        }
    }
}
