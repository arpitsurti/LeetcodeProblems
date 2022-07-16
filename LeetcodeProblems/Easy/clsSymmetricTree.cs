using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*101. Symmetric Tree
     * Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

        Example 1:
        Input: root = [1,2,2,3,4,4,3]
        Output: true

        Example 2:
        Input: root = [1,2,2,null,3,null,3]
        Output: false
 
        Constraints:
        The number of nodes in the tree is in the range [1, 1000].
        -100 <= Node.val <= 100
 
        Follow up: Could you solve it both recursively and iteratively?
    */
    public class clsSymmetricTree
    {
        /*RECURSIVE
        public bool IsSymmetric(TreeNode root) {
            return IsSymmetric(root.left, root.right);
        }
    
        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if(left == null && right == null)
                return true;
            else if(left == null || right == null)
                return false;
            else if(left.val == right.val)
                return IsSymmetric(left.left, right.right) && 
                IsSymmetric(left.right, right.left);
            return false;
        }
        */

        //ITERATIVE
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            else if (root.left == null || root.right == null)
                return root.left == root.right;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root.left != null && root.right != null)
            {
                queue.Enqueue(root.left);
                queue.Enqueue(root.right);
            }
            while (queue.Count != 0)
            {
                TreeNode leftNode = queue.Dequeue();
                TreeNode rightNode = queue.Dequeue();
                if (leftNode == null && rightNode == null)
                    continue;
                if (leftNode == null || rightNode == null)
                    return false;
                if (leftNode.val != rightNode.val)
                    return false;
                queue.Enqueue(leftNode.left);
                queue.Enqueue(rightNode.right);
                queue.Enqueue(leftNode.right);
                queue.Enqueue(rightNode.left);
            }
            return true;
        }
    }
}
