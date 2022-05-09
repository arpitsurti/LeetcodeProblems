using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*530. Minimum Absolute Difference in BST
     *** REF ***
     *https://leetcode.com/problems/minimum-absolute-difference-in-bst/discuss/585431/java-accepted-solution-inorder-with-clear-explanation
     * Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.

        Example 1:
        Input: root = [4,2,6,1,3]
        Output: 1

        Example 2:
        Input: root = [1,0,48,null,null,12,49]
        Output: 1
 
        Constraints:
        The number of nodes in the tree is in the range [2, 104].
        0 <= Node.val <= 105
 
        Note: This question is the same as 783: https://leetcode.com/problems/minimum-distance-between-bst-nodes/
    */
    public class clsMinimumAbsoluteDifferenceInBST
    {
        int minDiff = int.MaxValue;
        int prev = -1;
        public int GetMinimumDifference(TreeNode root)
        {
            if (root == null)
                return 0;
            GetMinimumDifference(root.left);
            if (prev != -1)
                minDiff = Math.Min(minDiff, Math.Abs(root.val - prev));
            prev = root.val;
            GetMinimumDifference(root.right);
            return minDiff;
        }
    }
}
