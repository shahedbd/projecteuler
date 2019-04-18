using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problems
{
    public static class P25HundredDigitFibo
    {
        public static BigInteger Get()
        {
            BigInteger i, f1 = 0, f2 = 1, f3 = 0;
            for (i = 1; ; i++)
            {
                f3 = f1 + f2;
                string abc = f3.ToString();
                if (abc.Length == 1000) break;
                f1 = f2;
                f2 = f3;
            }

            return i + 1;
        }


    }
}