using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*2006. Count Number of Pairs With Absolute Difference K
     *** REF ***
     * Given an integer array nums and an integer k, return the number of pairs (i, j) where i < j such that |nums[i] - nums[j]| == k.
        The value of |x| is defined as:
        x if x >= 0.
        -x if x < 0.

        Example 1:
        Input: nums = [1,2,2,1], k = 1
        Output: 4
        Explanation: The pairs with an absolute difference of 1 are:
        - [1,2,2,1]
        - [1,2,2,1]
        - [1,2,2,1]
        - [1,2,2,1]

        Example 2:
        Input: nums = [1,3], k = 3
        Output: 0
        Explanation: There are no pairs with an absolute difference of 3.

        Example 3:
        Input: nums = [3,2,1,5,4], k = 2
        Output: 3
        Explanation: The pairs with an absolute difference of 2 are:
        - [3,2,1,5,4]
        - [3,2,1,5,4]
        - [3,2,1,5,4]
 
        Constraints:
        1 <= nums.length <= 200
        1 <= nums[i] <= 100
        1 <= k <= 99
    */
    public class clsCountNumberOfPairsWithAbsoluteDifferenceK
    {
        public int CountKDifference(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i] - k))
                    result += dict[nums[i] - k];
                if (dict.ContainsKey(nums[i] + k))
                    result += dict[nums[i] + k];
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict.Add(nums[i], 1);
            }
            return result;
        }
    }
}
