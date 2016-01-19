using System;

namespace ProjectEuler
{
    /*
     * The following iterative sequence is defined for the set of positive integers:
     * 
     * n → n/2 (n is even)
     * n → 3n + 1 (n is odd)
     * 
     * Using the rule above and starting with 13, we generate the following sequence:
     * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
     * 
     * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
     * Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
     * 
     * Which starting number, under one million, produces the longest chain?
     * 
     * NOTE: Once the chain starts the terms are allowed to go above one million.
     */

    internal class Problem14 : Problem
    {
        public Problem14(long range)
        {
            Init(14, range, "The number under {0} that produces the longest Collatz chain is {1}");
        }

        protected override long Solve()
        {
            long maxChainStart = 1;
            long maxLength = 0;
            for (int i = 1; i <= InputParam; i++)
            {
                long chainStart = i;
                long length = 0;
                do
                {
                    length++;
                    chainStart = CollatzSequence(chainStart);
                } while (chainStart > 1);
                if (maxLength < length)
                {
                    maxLength = length;
                    maxChainStart = i;
                }
            }
            return maxChainStart;
        }

        private long CollatzSequence(long number)
        {
            if (number <= 0) throw new ArgumentOutOfRangeException("number","Collatz sequence is defined for positive integers only");

            switch (number % 2)
            {
                case 0:
                    return number/2;
                case 1:
                    return 3 * number + 1;
            }

            return 1;
        }
    }
}
