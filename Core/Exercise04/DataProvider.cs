using System;
using System.Linq;

namespace Core.Exercise04
{
    public class DataProvider : IDataProvideInteger
    {
        private string FilePath;
        public  DataProvider(string Path) {
            FilePath = 
                string.IsNullOrEmpty(Path) ? 
                throw new ArgumentException("Path is missing","Path"):
                Path;
        }
        /// <summary>
        /// Get long array from a file
        /// </summary>
        /// <returns></returns>
        public long[] GetIntegers()
        {
            string[] strLines = System.IO.File.ReadAllLines(FilePath);
            long[] Integers = new long[strLines.Length];
            for (int i=0; i< strLines.Length;++i)
            {
                var numbers = System.Text.RegularExpressions.Regex.Split(
                    strLines[i], 
                    "[^\\d]",
                    System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace);
                if (numbers == null) {
                    continue;
                }
                if (numbers.Length != 1)
                {
                    throw new FormatException("Lines on the file must have only one integer number");
                }
                Integers[i] = long.Parse(numbers[numbers.Length - 1]);
            }
            return Integers;
        }

    }
}
