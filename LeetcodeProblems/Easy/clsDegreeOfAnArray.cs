using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*697. Degree of an Array
     * Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.

        Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.

        Example 1:
        Input: nums = [1,2,2,3,1]
        Output: 2
        Explanation: 
        The input array has a degree of 2 because both elements 1 and 2 appear twice.
        Of the subarrays that have the same degree:
        [1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
        The shortest length is 2. So return 2.

        Example 2:
        Input: nums = [1,2,2,3,1,4,2]
        Output: 6
        Explanation: 
        The degree is 3 because the element 2 is repeated 3 times.
        So [2,2,3,1,4,2] is the shortest subarray, therefore returning 6.
 
        Constraints:
        nums.length will be between 1 and 50,000.
        nums[i] will be an integer between 0 and 49,999.
    */
    public class clsDegreeOfAnArray
    {
        public int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int output = int.MaxValue;
            int maxCount = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], new List<int>());
                dict[nums[i]].Add(i);
                if (dict[nums[i]].Count > maxCount)
                    maxCount = dict[nums[i]].Count;
            }

            foreach (var item in dict)
            {
                int count = item.Value.Count;
                if (count == maxCount)
                    output = Math.Min(item.Value[count - 1] - item.Value[0] + 1, output);
            }
            return output;
        }
    }
}
