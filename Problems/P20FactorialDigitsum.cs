using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P20FactorialDigitsum
    {
        public static long Get()
        {
            var result = LIB.sumOfDigits(LIB.Factorial(100));
            return (long)result;
        }


    }
}