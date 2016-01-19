namespace ProjectEuler
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, 
     * we get 3, 5, 6 and 9. The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */

    internal class Problem1 : Problem
    {
        public Problem1(int size)
        {
            ProblemNumber = 1;
            InputParam = size;
            OutputTemplate = "Sum of all the multiples of 3 or 5 below {0} equals {1}";
        }

        protected override long Solve()
        {
            long sum = 0;
            for (int i = 1; i < InputParam; i++)
            {
                if ((i%3 == 0) || (i%5 == 0))
                    sum += i;
            }
            return sum;
        }
    }
}
