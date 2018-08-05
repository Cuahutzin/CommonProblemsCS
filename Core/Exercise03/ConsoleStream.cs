using System;
using System.Collections.Generic;

namespace Core.Exercise03
{
    public class ConsoleStream:IPrintMultiplicationTableResult
    {
        public void Print(IEnumerable<MultiplicationTableResult> table) {
            foreach(var row in table)
            {
                Console.WriteLine("{0} X {1} = {2}", row.table, row.table, row.result);
            }
        }
    }
}
