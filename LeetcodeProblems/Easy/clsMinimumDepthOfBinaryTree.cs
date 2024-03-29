﻿using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*111. Minimum Depth of Binary Tree
     * Given a binary tree, find its minimum depth.
        The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
        Note: A leaf is a node with no children.

        Example 1:
        Input: root = [3,9,20,null,null,15,7]
        Output: 2

        Example 2:
        Input: root = [2,null,3,null,4,null,5,null,6]
        Output: 5
 
        Constraints:
        The number of nodes in the tree is in the range [0, 105].
        -1000 <= Node.val <= 1000
    */
    class clsMinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left != null && root.right == null)
                return MinDepth(root.left) + 1;
            else if (root.left == null && root.right != null)
                return MinDepth(root.right) + 1;
            return Math.Min(MinDepth(root.left) + 1, MinDepth(root.right) + 1);
        }
    }
}
