using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Hard
{
    /*896. Monotonic Array
     *** REF ***
     *An array is monotonic if it is either monotone increasing or monotone decreasing.

        An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].

        Given an integer array nums, return true if the given array is monotonic, or false otherwise.

        Example 1:
        Input: nums = [1,2,2,3]
        Output: true

        Example 2:
        Input: nums = [6,5,4,4]
        Output: true

        Example 3:
        Input: nums = [1,3,2]
        Output: false
 
        Constraints:
        1 <= nums.length <= 105
        -105 <= nums[i] <= 105
    */
    public class clsMonotonicArray
    {
        public bool IsMonotonic(int[] nums)
        {
            //APPROACH 1 ONE PASS SOLUTION
            bool isIncr = true;
            bool isDecr = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                    isIncr = false;
                if (nums[i] > nums[i + 1])
                    isDecr = false;
            }
            return isIncr || isDecr;

            /*
             APPROACH 2 TWO PASS SOLUTION
             public bool IsMonotonic(int[] nums) {
                    if(nums.Length == 1)
                        return true;
                    return IsIncreasing(nums) || IsDecreasing(nums);
            }
    
            private bool IsIncreasing(int[] nums)
            {
                for(int i = 0; i < nums.Length - 1; i++)
                {
                    if(nums[i] < nums[i+1])
                        return false;
                }
                return true;
            }
    
            private bool IsDecreasing(int[] nums)
            {
                for(int i = 0; i < nums.Length - 1; i++)
                {
                    if(nums[i] > nums[i+1])
                        return false;
                }
                return true;
            }
             */
        }
    }
}
