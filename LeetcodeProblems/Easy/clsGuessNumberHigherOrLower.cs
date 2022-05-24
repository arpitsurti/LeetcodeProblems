using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*374. Guess Number Higher or Lower
     * We are playing the Guess Game. The game is as follows:

        I pick a number from 1 to n. You have to guess which number I picked.

        Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.

        You call a pre-defined API int guess(int num), which returns three possible results:

        -1: Your guess is higher than the number I picked (i.e. num > pick).
        1: Your guess is lower than the number I picked (i.e. num < pick).
        0: your guess is equal to the number I picked (i.e. num == pick).
        Return the number that I picked.

        Example 1:
        Input: n = 10, pick = 6
        Output: 6
        
        Example 2:
        Input: n = 1, pick = 1
        Output: 1
    
        Example 3:
        Input: n = 2, pick = 1
        Output: 1

        Constraints:
        1 <= n <= 231 - 1
        1 <= pick <= n
    */
    public class clsGuessNumberHigherOrLower
    {
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int apiResult = guess(mid);
                if (apiResult == 0)
                    return mid;
                else if (apiResult == -1)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }
    }
}
