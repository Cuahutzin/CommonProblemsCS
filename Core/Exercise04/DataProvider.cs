using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Core.Exercise04
{
    public class DataProvider : IDataProvideInteger
    {
        private string FilePath;
        public DataProvider(string Path) {
            FilePath =
                string.IsNullOrEmpty(Path) ?
                throw new ArgumentException("Path is missing", "Path") :
                @Path;
        }
        /// <summary>
        /// Get long array from a file
        /// </summary>
        /// <returns></returns>
        public List<long> GetIntegers()
        {
            string[] strLines = File.ReadAllLines(FilePath);
            List<long> Integers = new List<long>();

            for (int i = 0; i < strLines.Length; ++i)
            {


                var regex = new System.Text.RegularExpressions.Regex(@"[^\d]");
                var line = regex.Replace(strLines[i], " ");

                var strNumbers = System.Text.RegularExpressions.Regex.Split(
                    line, 
                    @"[\D+]");
                if (strNumbers == null) {
                    continue;
                }
                var actualNumbers =
                    strNumbers.
                    Where(n => !String.IsNullOrEmpty(n)).
                    ToList();

                if (actualNumbers.Count() > 1)
                {
                    throw new FormatException("Lines on the file must have only one integer number");
                }
                if (actualNumbers.Count() == 1)
                {
                    Integers.Add(long.Parse(actualNumbers.ElementAt(0)));
                }
            }
            return Integers;
        }

    }
}
