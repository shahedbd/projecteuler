using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P21AmicableNumbers
    {
        public static long Execute()
        {
            int sum = 0;
            for (int i = 1; i < 10000; i++)
                if (isAmicable(i)) sum += i;

            return sum;
        }
        private static bool isAmicable(int number)
        {
            int result = LIB.divisorSum(number);
            return result != number && LIB.divisorSum(result) == number;
        }

    }
}