using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*215. Kth Largest Element in an Array.
     *** REF ***
     * Given an integer array nums and an integer k, return the kth largest element in the array.

        Note that it is the kth largest element in the sorted order, not the kth distinct element.

        Example 1:
        Input: nums = [3,2,1,5,6,4], k = 2
        Output: 5

        Example 2:
        Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
        Output: 4

        Constraints:
        1 <= k <= nums.length <= 104
        -104 <= nums[i] <= 104
    */
    public class clsKthLargestElementInAnArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            // Priority Queue is in .net 6 version
            /*
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i], nums[i]);
                if (queue.Count <= k)
                    continue;
                queue.Dequeue();
            }
            return queue.Peek();
            */
            return -1;
        }
    }
}
