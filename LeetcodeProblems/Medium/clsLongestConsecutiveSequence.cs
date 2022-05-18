using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*128. Longest Consecutive Sequence
     * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

        You must write an algorithm that runs in O(n) time.

        Example 1:
        Input: nums = [100,4,200,1,3,2]
        Output: 4
        Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

        Example 2:
        Input: nums = [0,3,7,2,5,8,4,6,0,1]
        Output: 9
 
        Constraints:
        0 <= nums.length <= 105
        -109 <= nums[i] <= 109
    */
    public class clsLongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                hs.Add(nums[i]);
            }
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(nums[i] - 1))
                {
                    int currCount = 1;
                    int currNum = nums[i];
                    while (hs.Contains(currNum + 1))
                    {
                        currNum++;
                        currCount++;
                    }
                    maxCount = Math.Max(currCount, maxCount);
                }
            }
            return maxCount;
        }
    }
}
