using Core.Excercise1.Extensions;
using NUnit.Framework;

namespace Core.Tests
{
    /// <summary>
    /// This is a class that
    /// </summary>
    [TestFixture]
    public class Excercise01
    {
        //[SetUp]
        //public void SetUp()
        //{

        //}
        [Test]
        [TestCase("anitalavalatina", "anitalavalatina")]
        [TestCase("a nitalavalatina", "anitalavalatin a")]
        [TestCase("", "")]

        public void ReverseStringBuilder_WhenCalled_ReturnInvertedString(string stringObject, string expectedResult)
        {
            var result = stringObject.ReverseStringBuilder();
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [TestCase("anitalavalatina", "anitalavalatina")]
        [TestCase("a nitalavalatina", "anitalavalatin a")]
        [TestCase("", "")]
        public void ReverseStringArray_WhenCalled_ReturnInvertedString(string stringObject, string expectedResult)
        {
            var result = stringObject.ReverseStringBuilder();
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [TestCase("anitalavalatina", "anitalavalatina")]
        [TestCase("a nitalavalatina", "anitalavalatin a")]
        [TestCase("", "")]
        public void ReverseStringDirectArray_WhenCalled_ReturnInvertedString(string stringObject, string expectedResult)
        {
            var result = stringObject.ReverseStringBuilder();
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
