using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*572. Subtree of Another Tree
     *** REF ***
     *https://leetcode.com/problems/subtree-of-another-tree/discuss/2176243/Java-Recursion-oror-simplified
     * Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

        A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. The tree tree could also be considered as a subtree of itself.

        Example 1:
        Input: root = [3,4,5,1,2], subRoot = [4,1,2]
        Output: true
        
        Example 2:
        Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]
        Output: false

        Constraints:
        The number of nodes in the root tree is in the range [1, 2000].
        The number of nodes in the subRoot tree is in the range [1, 1000].
        -104 <= root.val <= 104
        -104 <= subRoot.val <= 104
    */
    public class clsSubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
                return false;
            if (SameTree(root, subRoot))
                return true;
            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        private bool SameTree(TreeNode root, TreeNode subRoot)
        {
            if (root == null || subRoot == null)
                return root == subRoot;
            return root.val == subRoot.val && SameTree(root.left, subRoot.left)
                && SameTree(root.right, subRoot.right);

        }
    }
}
