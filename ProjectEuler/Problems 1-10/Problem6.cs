﻿namespace ProjectEuler
{
    /* Find the difference between the sum of the squares of the 
     * first one hundred natural numbers and the square of the sum.
     */

    internal class Problem6 : Problem
    {
        public Problem6(int count)
        {
            ProblemNumber = 6;
            InputParam = count;
            OutputTemplate =
                "The difference between the sum of the squares of the first {0} natural numbers and the square of the sum is {1}";
        }

  
        protected override long Solve()
        {
            long diff = 0;

            for (int i = 1; i <= InputParam; i++)
                for (int j = 1; j <= InputParam; j++)
                {
                    if (i != j)
                        diff += i * j;
                }

            return diff;
        }
    }
}
