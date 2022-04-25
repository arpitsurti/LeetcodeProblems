using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*412. Fizz Buzz
     * Given an integer n, return a string array answer (1-indexed) where:

        answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
        answer[i] == "Fizz" if i is divisible by 3.
        answer[i] == "Buzz" if i is divisible by 5.
        answer[i] == i (as a string) if none of the above conditions are true.

        Example 1:
        Input: n = 3
        Output: ["1","2","Fizz"]

        Example 2:
        Input: n = 5
        Output: ["1","2","Fizz","4","Buzz"]

        Example 3:
        Input: n = 15
        Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 
        Constraints:
        1 <= n <= 104
    */
    class clsFizzBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> lstResult = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                bool divisibleBy3 = (i % 3 == 0);
                bool divisibleBy5 = (i % 5 == 0);
                if (divisibleBy3 && divisibleBy5)
                    lstResult.Add("FizzBuzz");
                else if (divisibleBy3)
                    lstResult.Add("Fizz");
                else if (divisibleBy5)
                    lstResult.Add("Buzz");
                else
                    lstResult.Add("" + i);
            }
            return lstResult;
        }
    }
}
