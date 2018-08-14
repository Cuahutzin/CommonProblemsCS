using Core.Exercise03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests.Exercise03
{
    public class MultiplicationTableResultComparer:IEqualityComparer<MultiplicationTableResult>
    {
        public bool Equals(MultiplicationTableResult x, MultiplicationTableResult y)
        {
            if ((x == null && y == null) || ReferenceEquals(x,y))
            {
                return true;
            }
            else if ((x == null || y == null))
            {
                return false;
            }
            return (x.result == y.result && x.table == y.table && x.times == y.times);
        }

        public int GetHashCode(MultiplicationTableResult obj)
        {
            return obj.table.GetHashCode() ^ obj.times.GetHashCode() ^ obj.result.GetHashCode();
        }
    }
}
