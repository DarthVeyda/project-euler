using System;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /*
     * The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
     * 
     * 73167176531330624919225119674426574742355349194934
     * 96983520312774506326239578318016984801869478851843
     * 85861560789112949495459501737958331952853208805511
     * 12540698747158523863050715693290963295227443043557
     * 66896648950445244523161731856403098711121722383113
     * 62229893423380308135336276614282806444486645238749
     * 30358907296290491560440772390713810515859307960866
     * 70172427121883998797908792274921901699720888093776
     * 65727333001053367881220235421809751254540594752243
     * 52584907711670556013604839586446706324415722155397
     * 53697817977846174064955149290862569321978468622482
     * 83972241375657056057490261407972968652414535100474
     * 82166370484403199890008895243450658541227588666881
     * 16427171479924442928230863465674813919123162824586
     * 17866458359124566529476545682848912883142607690042
     * 24219022671055626321111109370544217506941658960408
     * 07198403850962455444362981230987879927244284909188
     * 84580156166097919133875499200524063689912560717606
     * 05886116467109405077541002256983155200055935729725
     * 71636269561882670428252483600823257530420752963450
     * 
     * Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. 
     * What is the value of this product?
*/

    internal class Problem8 : Problem
    {
        private readonly string _bigNumber;

        private readonly byte[] _sequence;

        public Problem8(int length) 
        {
            _bigNumber = "73167176531330624919225119674426574742355349194934"
+"96983520312774506326239578318016984801869478851843"
+"85861560789112949495459501737958331952853208805511"
+"12540698747158523863050715693290963295227443043557"
+"66896648950445244523161731856403098711121722383113"
+"62229893423380308135336276614282806444486645238749"
+"30358907296290491560440772390713810515859307960866"
+"70172427121883998797908792274921901699720888093776"
+"65727333001053367881220235421809751254540594752243"
+"52584907711670556013604839586446706324415722155397"
+"53697817977846174064955149290862569321978468622482"
+"83972241375657056057490261407972968652414535100474"
+"82166370484403199890008895243450658541227588666881"
+"16427171479924442928230863465674813919123162824586"
+"17866458359124566529476545682848912883142607690042"
+"24219022671055626321111109370544217506941658960408"
+"07198403850962455444362981230987879927244284909188"
+"84580156166097919133875499200524063689912560717606"
+"05886116467109405077541002256983155200055935729725"
+"71636269561882670428252483600823257530420752963450";

            ProblemNumber = 8;
            InputParam = length;
            _sequence = new byte[InputParam];
            OutputTemplate = "The greatest product of {0} adjacent digits in the 1000-digit number is {1}";
        }

        protected override long Solve() 
        {
            int maxStart = 0;
            int maxEnd = 0;
            long maxProduct = 0;
            for (int startIndex = 0; startIndex <= _bigNumber.Length - InputParam; startIndex++)
            {
                int endIndex = startIndex + (int) InputParam - 1;
                FillSequence(startIndex, endIndex);

                long sequenceProduct = _sequence.Aggregate<byte, long>(1, (current, digit) => current * digit);

                bool isBigger = sequenceProduct > maxProduct;
                maxProduct = isBigger ? sequenceProduct : maxProduct;
                maxStart = isBigger ? startIndex : maxStart;
                maxEnd = isBigger ? endIndex : maxEnd;
            }

            FillSequence(maxStart, maxEnd);
            return maxProduct;
        }

        private void FillSequence(int startIndex, int endIndex)
        {
            for (int i = startIndex; i <= endIndex; i++) 
            {
                _sequence[i - startIndex] = Convert.ToByte(_bigNumber.Substring(i,1)); 
            }
        }



        //the only reason I have this mess is that I wanted a fancier output. Really should rewrite it properly :(
        public new StringBuilder SolutionOutput()
        {
            long tmp = Solve();
            string showResult = string.Join("x", _sequence) + " = " + tmp;
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Problem {0}:\n", ProblemNumber);
            result.AppendFormat(OutputTemplate, InputParam, showResult);
            return result;
        }
    }
}
