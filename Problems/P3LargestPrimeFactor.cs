using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P3LargestPrimeFactor
    {
        public static long Get(long number)
        {
            for (long i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) number /= i;
            }
            return number;
        }

        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 3; i <= boundary; i += 2)
                if (number % i == 0) return false;
            return true;
        }


    }
}