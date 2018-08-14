using System.Collections.Generic;

namespace Core.Exercise03
{
    public interface IPrintMultiplicationTableResult
    {
        void Print(IEnumerable<MultiplicationTableResult> table);
    }
}