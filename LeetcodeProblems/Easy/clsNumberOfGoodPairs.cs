using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1512. Number of Good Pairs
     * Given an array of integers nums, return the number of good pairs.
        A pair (i, j) is called good if nums[i] == nums[j] and i < j.

        Example 1:
        Input: nums = [1,2,3,1,1,3]
        Output: 4
        Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.

        Example 2:
        Input: nums = [1,1,1,1]
        Output: 6
        Explanation: Each pair in the array are good.

        Example 3:
        Input: nums = [1,2,3]
        Output: 0
 
        Constraints:
        1 <= nums.length <= 100
        1 <= nums[i] <= 100
    */
    public class clsNumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            //APPROACH 2
            //TO CALCULATE THE FREQUENCY OF THE NUMBER USE FORMULA N * (N - 1) / 2
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int output = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], 1);
                else
                    dict[nums[i]]++;
            }
            foreach (var item in dict.Values)
            {
                if (item > 1)
                    output += (item * (item - 1) / 2);
            }
            return output;
            /*
             * APPROACH 1
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    count += dict[nums[i]];
                    dict[nums[i]]++;
                }
                else
                    dict.Add(nums[i], 1);
            }
            return count;
            */
        }
    }
}
