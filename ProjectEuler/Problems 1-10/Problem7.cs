namespace ProjectEuler
{
    /*
     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
     * What is the 10 001st prime number?
*/

    internal class Problem7 : Problem
    {
        public Problem7(int number)
        {
            ProblemNumber = 7;
            InputParam = number;
            OutputTemplate = "The {0}th prime number is {1}";
        }

        protected override long Solve() 
        {
            long NthPrime = 1;
            int Count = 0;
            do 
            {
                NthPrime++;
                if (CommonFunctions.IsPrime(NthPrime))
                    Count++;
            } 
            while (Count < InputParam);

            return NthPrime;
        }
    }
}
