using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P10SummationofPrimes
    {
        public static long Get(long number)
        {
            long primeSum = 0;
            for (int i = 0; i < number; i++)
            {
                if (IsPimeNumber(i)) primeSum += i;
            }
            return primeSum;
        }
        static bool IsPimeNumber(long N)
        {
            if (N == 1) return false;
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0) return false;
            }

            return true;
        }

    }
}