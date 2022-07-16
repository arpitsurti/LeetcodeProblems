using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;

namespace LeetcodeProblems.Easy
{
    /*104. Maximum Depth of Binary Tree
     * Given the root of a binary tree, return its maximum depth.
        A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

        Example 1:
        Input: root = [3,9,20,null,null,15,7]
        Output: 3

        Example 2:
        Input: root = [1,null,2]
        Output: 2

        Constraints:
        The number of nodes in the tree is in the range [0, 104].
        -100 <= Node.val <= 100
    */
    public class clsMaximumDepthOfBinaryTree
    {
        /*Recursive
        public int MaxDepth(TreeNode root) {
            if(root == null)
                return 0;
            return Math.Max(MaxDepth(root.left) + 1, MaxDepth(root.right) + 1);
        }
        */

        //Iterative
        public int MaxDepth(TreeNode root)
        {
            int depth = 0;
            if (root == null)
                return depth;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                depth++;
                int size = queue.Count();
                while (size-- != 0)
                {
                    TreeNode curr = queue.Dequeue();
                    if (curr.left != null)
                        queue.Enqueue(curr.left);
                    if (curr.right != null)
                        queue.Enqueue(curr.right);
                }
            }
            return depth;
        }
    }
}
