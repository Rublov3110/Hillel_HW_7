using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_HW_7
{
    public static class LinqExtensions
    {
        public static T Penultimate<T>(this IEnumerable<T> source)
        {
            var penultimate = source.Reverse().Skip(1).FirstOrDefault();
            return penultimate;
        }
    }
}
