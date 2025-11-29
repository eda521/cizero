using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleApp
{
    public static class NumberAnalyzer
    {
        public static bool IsPrime(int value)
        {
            if (value <= 1) return false;
            if (value <= 3) return true;
            if (value % 2 == 0) return false;
            var limit = (int)Math.Sqrt(value);
            for (int i = 3; i <= limit; i += 2)
            {
                if (value % i == 0) return false;
            }
            return true;
        }

        public static double Mean(IEnumerable<double> values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            var arr = values as double[] ?? values.ToArray();
            if (arr.Length == 0) throw new ArgumentException("Sequence contains no elements.", nameof(values));
            return arr.Average();
        }

        public static double Median(IEnumerable<double> values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            var sorted = (values as double[] ?? values.ToArray()).OrderBy(x => x).ToArray();
            if (sorted.Length == 0) throw new ArgumentException("Sequence contains no elements.", nameof(values));
            int n = sorted.Length;
            if (n % 2 == 1) return sorted[n / 2];
            return (sorted[(n / 2) - 1] + sorted[n / 2]) / 2.0;
        }
    }
}