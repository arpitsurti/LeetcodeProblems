using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*1122. Relative Sort Array
     * Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.

        Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2. Elements that do not appear in arr2 should be placed at the end of arr1 in ascending order.

        Example 1:
        Input: arr1 = [2,3,1,3,2,4,6,7,9,2,19], arr2 = [2,1,4,3,9,6]
        Output: [2,2,2,1,4,3,3,9,6,7,19]

        Example 2:
        Input: arr1 = [28,6,22,8,44,17], arr2 = [22,28,8,6]
        Output: [22,28,8,6,17,44]
 
        Constraints:
        1 <= arr1.length, arr2.length <= 1000
        0 <= arr1[i], arr2[i] <= 1000
        All the elements of arr2 are distinct.
        Each arr2[i] is in arr1.
    */
    public class clsRelativeSortArray
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dict.ContainsKey(arr1[i]))
                    dict.Add(arr1[i], 0);
                dict[arr1[i]]++;
            }
            List<int> lstResult = new List<int>();
            for (int i = 0; i < arr2.Length; i++)
            {
                int element = arr2[i];
                int count = dict[element];
                while (count != 0)
                {
                    lstResult.Add(element);
                    count--;
                }
                dict.Remove(element);
            }
            foreach (var item in dict)
            {
                int count = item.Value;
                while (count != 0)
                {
                    lstResult.Add(item.Key);
                    count--;
                }
            }
            return lstResult.ToArray();
        }
    }
}
