using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*2215. Find the Difference of Two Arrays
     * Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

        answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
        answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
        Note that the integers in the lists may be returned in any order.

        Example 1:
        Input: nums1 = [1,2,3], nums2 = [2,4,6]
        Output: [[1,3],[4,6]]
        Explanation:
        For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].
        For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].

        Example 2:
        Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
        Output: [[3],[]]
        Explanation:
        For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
        Every integer in nums2 is present in nums1. Therefore, answer[1] = [].

        Constraints:
        1 <= nums1.length, nums2.length <= 1000
        -1000 <= nums1[i], nums2[i] <= 1000
    */
    public class clsFindTheDifferenceOfTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
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
            IList<IList<int>> lstResult = new List<IList<int>>();
            IList<int> lst1 = new List<int>();
            foreach (int num in hs1)
            {
                if (!hs2.Contains(num))
                    lst1.Add(num);
            }
            lstResult.Add(lst1);
            IList<int> lst2 = new List<int>();
            foreach (int num in hs2)
            {
                if (!hs1.Contains(num))
                    lst2.Add(num);
            }
            lstResult.Add(lst2);
            return lstResult;
        }
    }
}
