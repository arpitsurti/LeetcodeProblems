using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*189. Rotate Array
     *** REF ***
     *** VERY IMP ***
     * Given an array, rotate the array to the right by k steps, where k is non-negative.

        Example 1:
        Input: nums = [1,2,3,4,5,6,7], k = 3
        Output: [5,6,7,1,2,3,4]
        Explanation:
        rotate 1 steps to the right: [7,1,2,3,4,5,6]
        rotate 2 steps to the right: [6,7,1,2,3,4,5]
        rotate 3 steps to the right: [5,6,7,1,2,3,4]

        Example 2:
        Input: nums = [-1,-100,3,99], k = 2
        Output: [3,99,-1,-100]
        Explanation: 
        rotate 1 steps to the right: [99,-1,-100,3]
        rotate 2 steps to the right: [3,99,-1,-100]
 
        Constraints:
        1 <= nums.length <= 105
        -231 <= nums[i] <= 231 - 1
        0 <= k <= 105
 
        Follow up:
        Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
        Could you do it in-place with O(1) extra space?
    */
    public class clsRotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            //Reverse input array
            reverse(nums, 0, nums.Length - 1);
            //Reverse first k elements
            reverse(nums, 0, k - 1);
            //Reverse all element after k
            reverse(nums, k, nums.Length - 1);
        }

        private void reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                int temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
                right--;
                left++;
            }
        }
    }
}
