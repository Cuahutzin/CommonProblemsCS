using Core.Excercise03;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests.Excercise03
{
    [TestFixture]
    public class MultiplicationTableGeneratorUnitTests
    {
        private MultiplicationTableGenerator tableGenerator { get; set; }
        private MultiplicationTableResultComparer tableComparer { get; set; }
        [SetUp]
        public void SetUp()
        {
            tableGenerator = new MultiplicationTableGenerator();
            tableComparer = new MultiplicationTableResultComparer();
        }

        [Test]
        public void MultiplicationTable_GetTable_ReturnMultiplicationTableResultsCollection()
        {
            var result = tableGenerator.GetTable(2, 5);
            var expectedResult = new List<MultiplicationTableResult>
            {
                new MultiplicationTableResult{ table=2,times=1,result =2},
                new MultiplicationTableResult{ table=2,times=3,result =6},
                new MultiplicationTableResult{ table=2,times=2,result =4},
                new MultiplicationTableResult{ table=2,times=4,result =8},
                new MultiplicationTableResult{ table=2,times=5,result =10},
            };


            int intersectCount = 0;
            expectedResult.ForEach(x =>
            {
                if (result.Contains(x, tableComparer))
                    ++intersectCount;
            });

            var equalityResult =
                (intersectCount == expectedResult.Count &&
                result.Count == expectedResult.Count);

            Assert.That(equalityResult, Is.True);

            //Assert.That(result.SequenceEqual(expectedResult, tableComparer), Is.True);
        }
    }
}
