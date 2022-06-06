using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*653. Two Sum IV - Input is a BST
     *** REF ***
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
            HashSet<int> hs = new HashSet<int>();
            return iterate(root, hs, k);
        }

        private bool iterate(TreeNode curr, HashSet<int> hs, int k)
        {
            if (curr == null)
                return false;
            if (hs.Contains(k - curr.val))
                return true;
            hs.Add(curr.val);
            return iterate(curr.left, hs, k) || iterate(curr.right, hs, k);
        }
    }
}
