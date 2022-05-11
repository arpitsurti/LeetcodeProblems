using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*98. Validate Binary Search Tree
      Given the root of a binary tree, determine if it is a valid binary search tree (BST).
        *** REF ***
        *https://www.youtube.com/watch?v=gGsEVFP0aQo
        *https://www.youtube.com/watch?v=Z_-h_mpDmeg
        A valid BST is defined as follows:

        The left subtree of a node contains only nodes with keys less than the node's key.
        The right subtree of a node contains only nodes with keys greater than the node's key.
        Both the left and right subtrees must also be binary search trees.
 
        Example 1:
        Input: root = [2,1,3]
        Output: true
    
        Example 2:
        Input: root = [5,1,4,null,null,3,6]
        Output: false
        Explanation: The root node's value is 5 but its right child's value is 4.
 
        Constraints:
        The number of nodes in the tree is in the range [1, 104].
        -231 <= Node.val <= 231 - 1
    */
    public class clsValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return isValid(root, long.MinValue, long.MaxValue);
        }

        private bool isValid(TreeNode root, long minVal, long maxVal)
        {
            if (root == null)
                return true;
            if (root.val <= minVal || root.val >= maxVal)
                return false;
            return isValid(root.left, minVal, root.val) && isValid(root.right, root.val, maxVal);
        }
    }
}
