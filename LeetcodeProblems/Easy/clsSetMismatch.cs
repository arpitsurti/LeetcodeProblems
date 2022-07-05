using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*645. Set Mismatch
     * You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.
        You are given an integer array nums representing the data status of this set after the error.
        Find the number that occurs twice and the number that is missing and return them in the form of an array.

        Example 1:
        Input: nums = [1,2,2,4]
        Output: [2,3]

        Example 2:
        Input: nums = [1,1]
        Output: [1,2]
 
        Constraints:
        2 <= nums.length <= 104
        1 <= nums[i] <= 104
    */
    public class clsSetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            int[] result = new int[2];
            int sum = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (!hs.Add(nums[i]))
                    result[0] = nums[i];
                else
                    sum += nums[i];
            }
            result[1] = ((n * (n + 1)) / 2) - sum;
            return result;
        }
    }
}
