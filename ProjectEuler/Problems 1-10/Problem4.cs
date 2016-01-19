using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /*
     * A palindromic number reads the same both ways. 
     * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     */

    internal class Problem4 : Problem
    {
        private int Num1;
        private int Num2;

        public Problem4()
        {
            ProblemNumber = 4;
            OutputTemplate = "The largest palindrome made from the product of two 3-digit numbers is {2}x{1} = {0}";
        }

        protected override long Solve()
        {
            long MaxProduct = 0;
            var PalindromeProducts = Enumerable.Empty<object>()
             .Select(r => new { Num1 = (int)MaxProduct, Num2 = (int)MaxProduct, Product = MaxProduct }) // prototype of anonymous type
             .ToList();
            for (int Number1 = 999; Number1 >= 111; Number1--) 
            {
                for (int Number2 = 999; Number2 >= 111; Number2--) 
                {
                    long Product = Number1 * Number2;
                    string sProduct = Product.ToString();
                    if (Product >= 100001)
                    {
                        if ((sProduct[0] == sProduct[5]) && (sProduct[1] == sProduct[4]) && (sProduct[2] == sProduct[3]))
                        {
                            PalindromeProducts.Add(new { Num1 = Number1, Num2 = Number2, Product = Product });
                        }
                    }
                    else 
                    {
                        break;                       
                    }
                }
            }

            var m = PalindromeProducts.OrderByDescending(i => i.Product).FirstOrDefault();
            MaxProduct = m.Product;
            Num1 = m.Num1;
            Num2 = m.Num2;
            return MaxProduct;
        }


        public new StringBuilder SolutionOutput()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Problem {0}:\n", ProblemNumber);
            return result.AppendFormat(OutputTemplate, SolutionValue, Num1, Num2);
        }
    }
}
