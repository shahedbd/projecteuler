using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problems
{
    public static class LIB
    {
        public static int divisorSum(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
                if (number % i == 0) sum += i;

            return sum;
        }
        private static BigInteger LCM(BigInteger x, BigInteger y)
        {
            //return x.divide(GCD(x, y)).multiply(y);
            return 0;
        }

        public static BigInteger GCD(BigInteger p, BigInteger q)
        {
            if (q == 0) return p;
            BigInteger r = p % q;
            return GCD(q, r);
        }

        public static bool isPalindrome(String s)
        {
            return s.Equals(ReverseString(s));
        }

        public static bool isPalindrome(int x)
        {
            return isPalindrome(x.ToString());
        }

        public static string ReverseString(string srtVarable)
        {
            return new string(srtVarable.Reverse().ToArray());
        }

        public static bool isPalindrome(long number)
        {
            long tempNumber, remainder, reverse = 0;
            tempNumber = number;

            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            if (reverse == tempNumber) return true;
            else return false;
        }

        public static bool IsPandigital(int number)
        {
            int maxDigit = (int)Math.Log10(number) + 1;
            int allBitsExceptBitOne = (1 << (maxDigit + 1)) - 2;

            int digitBits = 0;
            while (number != 0)
            {
                int digit = number % 10;
                int mask = 1 << digit;
                if (digit == 0 || digit > maxDigit || (digitBits & mask) != 0)
                    return false;
                digitBits |= mask;
                number /= 10;
            }
            return digitBits == allBitsExceptBitOne;
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

        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 3; i <= boundary; i += 2)
                if (number % i == 0) return false;
            return true;
        }
        public static BigInteger sumOfDigits(BigInteger x)
        {
            BigInteger sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x = x / 10;
            }
            return sum;
        }
        public static BigInteger Factorial(BigInteger factNumber)
        {
            if (factNumber == 0) return 1;
            else
                return factNumber * Factorial(factNumber - 1);
        }


        public static object NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }

    }
}



