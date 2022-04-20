using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*2032. Two Out of Three
     * Given three integer arrays nums1, nums2, and nums3, return a distinct array containing all the values that are present in at least two out of the three arrays. You may return the values in any order.

        Example 1:
        Input: nums1 = [1,1,3,2], nums2 = [2,3], nums3 = [3]
        Output: [3,2]
        Explanation: The values that are present in at least two arrays are:
        - 3, in all three arrays.
        - 2, in nums1 and nums2.

        Example 2:
        Input: nums1 = [3,1], nums2 = [2,3], nums3 = [1,2]
        Output: [2,3,1]
        Explanation: The values that are present in at least two arrays are:
        - 2, in nums2 and nums3.
        - 3, in nums1 and nums2.
        - 1, in nums1 and nums3.

        Example 3:
        Input: nums1 = [1,2,2], nums2 = [4,3,3], nums3 = [5]
        Output: []
        Explanation: No value is present in at least two arrays.
 
        Constraints:
        1 <= nums1.length, nums2.length, nums3.length <= 100
        1 <= nums1[i], nums2[j], nums3[k] <= 100
    */
    public class clsTwoOutOfThree
    {
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            IList<int> lstResult = new List<int>();
            HashSet<int> hs1 = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();
            HashSet<int> hs3 = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                hs1.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                hs2.Add(nums2[i]);
            }
            for (int i = 0; i < nums3.Length; i++)
            {
                hs3.Add(nums3[i]);
            }
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (hs2.Contains(nums1[i]) || hs3.Contains(nums1[i]))
                    hs.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (hs1.Contains(nums2[i]) || hs3.Contains(nums2[i]))
                    hs.Add(nums2[i]);
            }
            for (int i = 0; i < nums3.Length; i++)
            {
                if (hs1.Contains(nums3[i]) || hs2.Contains(nums3[i]))
                    hs.Add(nums3[i]);
            }
            foreach (var item in hs)
            {
                lstResult.Add(item);
            }
            return lstResult;
        }
    }
}
