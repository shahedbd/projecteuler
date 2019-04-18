using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class P17NumberLetterCounts
    {
        public static int Get()
        {
            string wordLength = string.Empty;
            for (int i = 1; i <= 1000; i++)
            {
                var result = LIB.NumberToWords(i);
                wordLength += result;
            }
            int number = wordLength.Length - wordLength.Count(Char.IsWhiteSpace);
            return number;
        }

    }
}