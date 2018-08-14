using NUnit.Framework;
using Core.Exercise02;

namespace Core.Tests.Exercise02
{
    [TestFixture]
    public class FibonacciTests
    {
        private Fibonacci fibonacciObj;
        [SetUp]
        public void SetUp() {
            fibonacciObj = new Fibonacci();
        }
        
        [Test]
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(49, 7778742049)]
        [TestCase(36, 14930352)]
        [TestCase(3, 2)]
        [TestCase(8, 21)]
        public void WhenGetFibonacci_Called_ReturnFibonacci(long input, long fibonacciExpectedResult)
        {
            var result = fibonacciObj.GetFibonacci(input);
            Assert.That(result, Is.EqualTo(fibonacciExpectedResult));
        }
    }
}
