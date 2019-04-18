using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P41PandigitalPrime
    {
        public static long Get()
        {
            long number = 0;
            for (long i = 999999999; i > 0; i--)
            {
                string strNum = i.ToString();
                if (!strNum.Contains('0') && strNum.Length == strNum.Distinct().Count())
                {
                    if (LIB.IsPrime(i))
                    {
                        number = i;
                        break;
                    }
                }

            }
            return number;
        }

    }
}