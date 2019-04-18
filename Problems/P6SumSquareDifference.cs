using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P6SumSquareDifference
    {
        public static int Execute()
        {
            int numberSumSqr = 0;
            int sqrNumSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                numberSumSqr += i;
                sqrNumSum += i * i;
            }
            return numberSumSqr * numberSumSqr - sqrNumSum;
        }


    }
}