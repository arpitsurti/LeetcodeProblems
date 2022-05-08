using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*653. Two Sum IV - Input is a BST
     * Given the root of a Binary Search Tree and a target number k, return true if there exist two elements in the BST such that their sum is equal to the given target.

        Example 1:
        Input: root = [5,3,6,2,4,null,7], k = 9
        Output: true

        Example 2:
        Input: root = [5,3,6,2,4,null,7], k = 28
        Output: false

        Constraints:
        The number of nodes in the tree is in the range [1, 104].
        -104 <= Node.val <= 104
        root is guaranteed to be a valid binary search tree.
        -105 <= k <= 105
    */
    public class clsTwoSumIV_InputIsABST
    {
        public bool FindTarget(TreeNode root, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            return buildArray(root, dict, k);
        }

        private bool buildArray(TreeNode curr, Dictionary<int, int> dict, int k)
        {
            if (curr == null)
                return false;
            if (dict.ContainsKey(k - curr.val))
                return true;
            if (!dict.ContainsKey(curr.val))
                dict.Add(curr.val, k - curr.val);
            return buildArray(curr.left, dict, k) || buildArray(curr.right, dict, k);
        }
    }
}
