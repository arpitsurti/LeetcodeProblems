using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*349. Intersection of Two Arrays
     * Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

        Example 1:
        Input: nums1 = [1,2,2,1], nums2 = [2,2]
        Output: [2]
    
        Example 2:
        Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        Output: [9,4]
        Explanation: [4,9] is also accepted.
 
        Constraints:
        1 <= nums1.length, nums2.length <= 1000
        0 <= nums1[i], nums2[i] <= 1000
    */
    public class clsIntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hs1 = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                hs1.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                hs2.Add(nums2[i]);
            }
            if (hs1.Count > hs2.Count)
                return Intersection(hs1, hs2);
            else
                return Intersection(hs2, hs1);
        }

        private int[] Intersection(HashSet<int> hs1, HashSet<int> hs2)
        {
            List<int> lstResult = new List<int>();
            foreach (var item in hs1)
            {
                if (hs2.Contains(item))
                    lstResult.Add(item);
            }
            return lstResult.ToArray();
        }
    }
}
