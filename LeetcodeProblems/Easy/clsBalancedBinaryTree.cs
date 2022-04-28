using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*110. Balanced Binary Tree
     * Given a binary tree, determine if it is height-balanced.

        For this problem, a height-balanced binary tree is defined as:

        a binary tree in which the left and right subtrees of every node differ in height by no more than 1.

        Example 1:
        Input: root = [3,9,20,null,null,15,7]
        Output: true

        Example 2:
        Input: root = [1,2,2,3,3,null,null,4,4]
        Output: false

        Example 3:
        Input: root = []
        Output: true
 
        Constraints:
        The number of nodes in the tree is in the range [0, 5000].
        -104 <= Node.val <= 104
    */
    public class clsBalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (Math.Abs(height(root.left) - height(root.right)) <= 1)
                return (IsBalanced(root.left) && IsBalanced(root.right));
            return false;
        }

        private int height(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(height(root.left), height(root.right)) + 1;
        }
    }
}
