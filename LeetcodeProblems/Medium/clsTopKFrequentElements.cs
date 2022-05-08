using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*347. Top K Frequent Elements
     *** REF ***
     *** VERY IMP ***
     * Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

        Example 1:
        Input: nums = [1,1,1,2,2,3], k = 2
        Output: [1,2]

        Example 2:
        Input: nums = [1], k = 1
        Output: [1]

        Constraints:
        1 <= nums.length <= 105
        k is in the range [1, the number of unique elements in the array].
        It is guaranteed that the answer is unique.
 
        Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
    */
    public class clsTopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], 0);
                dict[nums[i]]++;
            }
            List<int>[] lstFrequency = new List<int>[nums.Length + 1];
            foreach (var item in dict)
            {
                int key = item.Key;
                int count = item.Value;
                if (lstFrequency[count] == null)
                    lstFrequency[count] = new List<int>();
                lstFrequency[count].Add(key);
            }
            int[] result = new int[k];
            int index = 0;
            for (int i = lstFrequency.Length - 1; i >= 0; i--)
            {
                if (lstFrequency[i] != null)
                {
                    foreach (var item in lstFrequency[i])
                    {
                        if (index >= k)
                            break;
                        result[index++] = item;
                    }
                }
            }
            return result;
        }
    }
}
