using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class DupWhere
    {
        public static IEnumerable<T> DupMethodWhere<T>(this IEnumerable<T> ts, Func<T, bool> predicate)
        {
            return new List<T>();
        }
    }
}
