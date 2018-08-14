using Core.Exercise03;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Tests.Exercise03
{
    public class MultiplicationTableResultEnumerableComparer : IEqualityComparer<IEnumerable<MultiplicationTableResult>>
    {
        /// <summary>
        /// IEqualityComparer for the element comparison is mandatory
        /// </summary>
        private readonly IEqualityComparer<MultiplicationTableResult> resultComparer;
        private MultiplicationTableResultEnumerableComparer() { }
        public MultiplicationTableResultEnumerableComparer(IEqualityComparer<MultiplicationTableResult> customComparer)
        {
            var a = new MultiplicationTableResultEnumerableComparer();

            resultComparer = customComparer ??
                throw new ArgumentNullException("customComparer",
                "IEqualityComparer<MultiplicationTableResult> instance must be provided");
        }

        public bool Equals(IEnumerable<MultiplicationTableResult> firstCollection,
            IEnumerable<MultiplicationTableResult> secondCollection)
        {
            if ((firstCollection == null && secondCollection == null) ||
                ReferenceEquals(firstCollection, secondCollection))
            {
                return true;
            }
            else if ((firstCollection == null || secondCollection == null))
            {
                return false;
            }
            return ElementsAreEqual(firstCollection, secondCollection);
        }

        public int GetHashCode(IEnumerable<MultiplicationTableResult> obj)
        {
            var totalElements = obj.Count();
            if (totalElements == 0)
            {
                return base.GetHashCode();
            }
            var HasCode = resultComparer.GetHashCode(obj.First());
            for (int i = 1; i < totalElements - 1; ++i)
            {
                HasCode ^= resultComparer.GetHashCode(obj.ElementAt(i));
            }
            return HasCode;
        }

        /// <summary>
        /// Check if elements are equal for between collections provided
        /// </summary>
        /// <param name="firstCollection"></param>
        /// <param name="secondCollection"></param>
        /// <returns></returns>
        private bool ElementsAreEqual(IEnumerable<MultiplicationTableResult> firstCollection,
            IEnumerable<MultiplicationTableResult> secondCollection)

        {
            if (firstCollection.Count() == secondCollection.Count())
            {
                if (firstCollection.Count() == 0) return true;
                foreach (var result in firstCollection)
                {
                    if (!secondCollection.Contains(result, resultComparer))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
