﻿using System;

namespace ProjectEuler
{
    /*
     * Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
     * By starting with 1 and 2, the first 10 terms will be:
     * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
     * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
     * find the sum of the even-valued terms.
     */

    internal class Problem2 : Problem
    {
        public Problem2(int cap)
        {
            ProblemNumber = 2;
            InputParam = cap;
            OutputTemplate = "The sum of the even-valued terms in Fibonacci sequence lesser than {0} equals {1}";
        }

        protected override long Solve() 
        {
            long Sum = 0;
            int Term = 0;
            int Count = 1;
            
            do 
            {
                //an = [ Phin - (phi)n ]/Sqrt[5] - formula for n-th Fibonacci number
                Term = Convert.ToInt32((Math.Pow(Constants.Phi, Count) - Math.Pow(Constants.phi, Count)) / Math.Sqrt(5));
                if (Term % 2 == 0)
                    Sum += Term;
                Count++;
            } 
            while (Term <= InputParam);

            return Sum;
        }
    }
}
