using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Excercise03
{
    public class MultiplicationTableGenerator
    {
        public List<MultiplicationTableResult> GetTable(int tableNumber, int MultiplicationLimit)
        {
            List<MultiplicationTableResult> tableResults = new List<MultiplicationTableResult>();
            for (int i = 1; i <= MultiplicationLimit; ++i)
            {
                tableResults.Add(new MultiplicationTableResult{
                    table = tableNumber,
                    times = i,
                    result = tableNumber * i
                });
            }
            return tableResults;
        }

    }
}
