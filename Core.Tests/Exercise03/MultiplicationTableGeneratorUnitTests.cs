using Core.Exercise03;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Tests.Exercise03
{
    [TestFixture]
    public class MultiplicationTableGeneratorUnitTests
    {
        private MultiplicationTableGenerator tableGenerator { get; set; }
        private MultiplicationTableResultComparer tableResultComparer;
        private MultiplicationTableResultEnumerableComparer tableCollectionResultComparer;

        [SetUp]
        public void SetUp()
        {
            tableGenerator = new MultiplicationTableGenerator();
            tableResultComparer = new MultiplicationTableResultComparer();
            tableCollectionResultComparer = new MultiplicationTableResultEnumerableComparer(tableResultComparer);
        }

        [Test]
        public void MultiplicationTable_GetTable_ReturnMultiplicationTableResultsCollection()
        {
            var result = tableGenerator.GetTable(2, 5);
            var expectedResult = new List<MultiplicationTableResult>
            {
                new MultiplicationTableResult{ table=2,times=2,result =4},
                new MultiplicationTableResult{ table=2,times=4,result =8},
                new MultiplicationTableResult{ table=2,times=1,result =2},
                new MultiplicationTableResult{ table=2,times=3,result =6},
                new MultiplicationTableResult{ table=2,times=5,result =10}
            };
            Assert.That(tableCollectionResultComparer.Equals(result, expectedResult), Is.True);
        }
    }
}
