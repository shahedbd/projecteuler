using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P710001stPrime
    {
        public static long Get(long number)
        {
            int PrimeCount = 0;
            for (long i = 1; i <= 1000000; i++)
            {
                if (IsPimeNumber(i) == true)
                {
                    // Console.WriteLine(PrimeCount);
                    PrimeCount++;
                }

                if (PrimeCount == number)
                {
                    number = i;
                    break;
                }
            }
            return number;
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