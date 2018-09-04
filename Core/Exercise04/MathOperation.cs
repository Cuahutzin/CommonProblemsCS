
namespace Core.Exercise04
{
    public class MathOperation : IMathOperationSumIntegers
    {
        public long SumIntegers(long[] LongArray)
        {
            long value = 0;
            int length = LongArray.Length;
            for(int i=0;i< length; i++)
            {
                value += LongArray[i];
            }
            return value;
        }
    }
}
