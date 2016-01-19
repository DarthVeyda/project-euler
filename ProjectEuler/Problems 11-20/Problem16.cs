﻿using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    /*
     * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
     * What is the sum of the digits of the number 2^1000?
     */

    internal class Problem16 : Problem
    {
        /*
         * For now there seems to be no analytical solution for this problem
         */

        public Problem16()
        {
            Init(16, -1, "The sum of the digits of the number 2^1000 is {1}");
        }

        protected override long Solve()
        {
            return BigInteger.Pow(2, 1000).ToString().Sum(el => long.Parse(el.ToString()));
                //ToByteArray() returns incorrect values (all zeroes???)
        }
    }
}
