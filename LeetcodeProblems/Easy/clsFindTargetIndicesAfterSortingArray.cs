using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*2089. Find Target Indices After Sorting Array
     * You are given a 0-indexed integer array nums and a target element target.
        A target index is an index i such that nums[i] == target.
        Return a list of the target indices of nums after sorting nums in non-decreasing order. If there are no target indices, return an empty list. The returned list must be sorted in increasing order.
 
        Example 1:
        Input: nums = [1,2,5,2,3], target = 2
        Output: [1,2]
        Explanation: After sorting, nums is [1,2,2,3,5].
        The indices where nums[i] == 2 are 1 and 2.

        Example 2:
        Input: nums = [1,2,5,2,3], target = 3
        Output: [3]
        Explanation: After sorting, nums is [1,2,2,3,5].
        The index where nums[i] == 3 is 3.

        Example 3:
        Input: nums = [1,2,5,2,3], target = 5
        Output: [4]
        Explanation: After sorting, nums is [1,2,2,3,5].
        The index where nums[i] == 5 is 4.

        Constraints:
        1 <= nums.length <= 100
        1 <= nums[i], target <= 100
    */
    public class clsFindTargetIndicesAfterSortingArray
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            /* Smart Approach
             int lessThan = 0;
        int count = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i] == target)
                count++;
            else if(nums[i] < target)
                lessThan++;
        }
        List<int> lstResult = new List<int>();
        for(int i=0;i<count;i++)
        {
            lstResult.Add(lessThan++);
        }
        return lstResult;
            */
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i]);
                min = Math.Min(min, nums[i]);
            }

            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i] - min]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            int index = nums.Length - 1;
            while (index >= 0)
            {
                output[count[nums[index] - min] - 1] = nums[index];
                count[nums[index] - min]--;
                index--;
            }
            IList<int> lstResult = new List<int>();
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == target)
                    lstResult.Add(i);
                else if (output[i] > target)
                    break;
            }
            return lstResult;
        }
    }
}
