using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*1679. Max Number of K-Sum Pairs
     *** REF ***
     * You are given an integer array nums and an integer k.

        In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.
        Return the maximum number of operations you can perform on the array.

        Example 1:
        Input: nums = [1,2,3,4], k = 5
        Output: 2
        Explanation: Starting with nums = [1,2,3,4]:
        - Remove numbers 1 and 4, then nums = [2,3]
        - Remove numbers 2 and 3, then nums = []
        There are no more pairs that sum up to 5, hence a total of 2 operations.

        Example 2:
        Input: nums = [3,1,3,4,3], k = 6
        Output: 1
        Explanation: Starting with nums = [3,1,3,4,3]:
        - Remove the first two 3's, then nums = [1,4,3]
        There are no more pairs that sum up to 6, hence a total of 1 operation.
 
        Constraints:
        1 <= nums.length <= 105
        1 <= nums[i] <= 109
        1 <= k <= 109
    */
    public class clsMaxNumberOfKSumPairs
    {
        public int MaxOperations(int[] nums, int k)
        {
            int output = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int res = k - nums[i];
                if (dict.ContainsKey(res))
                {
                    output++;
                    if (dict[res] == 1)
                        dict.Remove(res);
                    else
                        dict[res]--;
                }
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], 1);
                    else
                        dict[nums[i]]++;
                }
            }
            return output;
        }
    }
}
