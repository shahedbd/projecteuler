using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problems
{
    public static class P16PowerDigitSum
    {
        public static int Get()
        {
            var result = BigInteger.Pow(new BigInteger(2), 1000).ToString();
            int sum = 0;
            for (int i = 0; i < result.Length; i++)
                sum += result[i] - '0';
            return sum;
        }

    }
}