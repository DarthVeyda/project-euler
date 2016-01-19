using System;

namespace ProjectEuler
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

    internal class Problem3 : Problem
    {
        public Problem3(long number)
        {
            ProblemNumber = 3;
            InputParam = number;
            OutputTemplate = "The largest prime factor of the number {0} is {1}";
        }

        protected override long Solve() 
        {
            long maxFactor = 1;
            for (long p = Convert.ToInt64(Math.Truncate(Math.Sqrt(InputParam))); p >= 2; p--) 
            {
                if (InputParam % p == 0)
                {
                    if (CommonFunctions.IsPrime(p))
                    {
                        maxFactor = p;
                        break;
                    }
                }
            }

            return maxFactor;
        }
    }
}
