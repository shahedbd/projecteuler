using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P4LargestPalindromeProduct
    {
        public static long Get()
        {
            int maxPalindrome = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (LIB.isPalindrome(i * j) && (i * j) > maxPalindrome)
                        maxPalindrome = i * j;
                }
            }
            return maxPalindrome;
        }

    }
}