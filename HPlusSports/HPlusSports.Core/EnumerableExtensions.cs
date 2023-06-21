using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSports.Core
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> FilterSelect<T, TResult>(this IEnumerable<T> enumerable, Func<T, bool> filter, Func<T, TResult> selector)
        {
            foreach (var item in enumerable)
            {
                if (filter(item))
                {
                    yield return selector(item);
                }
            }
        }
    }
}