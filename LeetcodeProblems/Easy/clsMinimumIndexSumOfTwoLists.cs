using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*599. Minimum Index Sum of Two Lists
     *** VERY IMP ***
     * Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a list of favorite restaurants represented by strings.

        You need to help them find out their common interest with the least list index sum. If there is a choice tie between answers, output all of them with no order requirement. You could assume there always exists an answer.

        Example 1:
        Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]
        Output: ["Shogun"]
        Explanation: The only restaurant they both like is "Shogun".

        Example 2:
        Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["KFC","Shogun","Burger King"]
        Output: ["Shogun"]
        Explanation: The restaurant they both like and have the least index sum is "Shogun" with index sum 1 (0+1).

        Constraints:
        1 <= list1.length, list2.length <= 1000
        1 <= list1[i].length, list2[i].length <= 30
        list1[i] and list2[i] consist of spaces ' ' and English letters.
        All the stings of list1 are unique.
        All the stings of list2 are unique.
    */
    public class clsMinimumIndexSumOfTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> lstResult = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
               dict.Add(list1[i], i);
            }
            int minSum = int.MaxValue;
            int currSum;
            for (int i = 0; i < list2.Length && i <= minSum; i++)
            {
                if (dict.ContainsKey(list2[i]))
                {
                    currSum = i + dict[list2[i]];
                    if (currSum == minSum)
                        lstResult.Add(list2[i]);
                    else if (currSum < minSum)
                    {
                        minSum = currSum;
                        lstResult.Clear();
                        lstResult.Add(list2[i]);
                    }
                }
            }
            return lstResult.ToArray();
        }
    }
}
