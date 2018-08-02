using Core.Excercise1.Extensions;
using NUnit.Framework;

namespace Core.Tests.Exercise01
{
    /// <summary>
    /// This is an unit test class for Excersice 01 
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
