using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*485. Max Consecutive Ones
     * Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:
        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

        Example 2:
        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:
        1 <= nums.length <= 105
        nums[i] is either 0 or 1.
    */
    public class clsMaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int currCount = 0;
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    currCount++;
                else
                    currCount = 0;
                maxCount = Math.Max(maxCount, currCount);
            }
            return maxCount;
        }
    }
}
