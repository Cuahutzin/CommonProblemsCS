using Core.Exercise04;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Core.Tests.Exercise04
{
    [TestFixture]
    public class DataProviderTests
    {
        private string baseFolder = @Path.Combine(
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).
                Parent.Parent.FullName, @"Exercise04\TestFiles");

        [Test]
        [TestCase(@"DataProviderTestFile_OK_EmptyFile.txt")]
        
        public void GetIntegers_WhenCalled_ReturnEmptyList(string filepath)
        {
            var expectedResult = new List<long>();
            var dataProvider = new DataProvider(Path.Combine(baseFolder, filepath));
            var result = dataProvider.GetIntegers();
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [Test]
        public void GetIntegers_WhenCalled_ReturnIntegerList()
        {
            var expectedResult =
                new List<long> { 1, 42, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 23, 14, 16, 15 };
            var filepath = "DataProviderTestFile_OK_MultipleLinesOneNumberEach.txt";
            var dataProvider = new DataProvider(Path.Combine(baseFolder, filepath));
            var result = dataProvider.GetIntegers();
            CollectionAssert.AreEquivalent(expectedResult, result);
        }
    }
}