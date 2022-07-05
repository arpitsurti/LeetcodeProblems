using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*414. Third Maximum Number
     *** REF ***
     * Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

        Example 1:
        Input: nums = [3,2,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2.
        The third distinct maximum is 1.

        Example 2:
        Input: nums = [1,2]
        Output: 2
        Explanation:
        The first distinct maximum is 2.
        The second distinct maximum is 1.
        The third distinct maximum does not exist, so the maximum (2) is returned instead.

        Example 3:
        Input: nums = [2,2,3,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2 (both 2's are counted together since they have the same value).
        The third distinct maximum is 1.
 
        Constraints:
        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
 
        Follow up: Can you find an O(n) solution?
    */
    public class clsThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            /*long firstNum = long.MinValue;//Missed to use long if actually i get int.MinVAlue in the input
            long secondNum = long.MinValue;
            long thirdNum = long.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > firstNum)
                {
                    thirdNum = secondNum;
                    secondNum = firstNum;
                    firstNum = nums[i];
                }
                else if (firstNum == nums[i])
                    continue;
                else if (nums[i] > secondNum)
                {
                    thirdNum = secondNum;
                    secondNum = nums[i];
                }
                else if (secondNum == nums[i])
                    continue;
                else if (nums[i] > thirdNum)
                    thirdNum = nums[i];
            }
            return thirdNum == long.MinValue ? (int)firstNum : (int)thirdNum;
            */
            int? first = null;
            int? second = null;
            int? third = null;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == first || nums[i] == second || nums[i] == third)
                    continue;
                if (first == null || nums[i] > first)
                {
                    second = first;
                    third = second;
                    first = nums[i];
                }
                else if (second == null || nums[i] > second)
                {
                    third = second;
                    second = nums[i];
                }
                else if (third == null || nums[i] > third)
                    third = nums[i];
            }
            return third.HasValue ? third.Value : first.Value;
        }
    }
}
