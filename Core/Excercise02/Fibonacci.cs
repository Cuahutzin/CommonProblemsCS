using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Excercise02
{
    public class Fibonacci
    {
        /// <summary>
        /// Memory cache for improve the performance
        /// </summary>
        private Dictionary<long, long> FibonacciCache;
        public Fibonacci() {
            FibonacciCache = new Dictionary<long, long> {
                {0,0},
                {1,1}
            };  
        }
        public long GetFibonacci(long n) {
            long value = 0;

            if (!FibonacciCache.TryGetValue(n, out value))
            {
                value = (GetFibonacci(n - 1) + GetFibonacci(n - 2));
                FibonacciCache.Add(n, value);
            }
            return value;
        }
    }
}
