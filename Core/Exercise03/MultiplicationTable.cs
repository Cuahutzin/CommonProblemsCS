using System.Collections.Generic;

namespace Core.Exercise03
{
    public class MultiplicationTableGenerator
    {
        /// <summary>
        /// Get Multiplication table providing table numbet and the multiplication limit
        /// </summary>
        /// <param name="tableNumber"></param>
        /// <param name="MultiplicationLimit"></param>
        /// <returns></returns>
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
