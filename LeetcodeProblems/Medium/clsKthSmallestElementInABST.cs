﻿using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Medium
{
    /*230. Kth Smallest Element in a BST
     * Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.

        Example 1:
        Input: root = [3,1,4,null,2], k = 1
        Output: 1

        Example 2:
        Input: root = [5,3,6,2,4,null,null,1], k = 3
        Output: 3
 
        Constraints:
        The number of nodes in the tree is n.
        1 <= k <= n <= 104
        0 <= Node.val <= 104
 
        Follow up: If the BST is modified often (i.e., we can do insert and delete operations) and you need to find the kth smallest frequently, how would you optimize?
    */
    public class clsKthSmallestElementInABST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            List<int> lstResult = new List<int>();
            populateList(root, k, lstResult);
            return lstResult[k - 1];
        }

        private void populateList(TreeNode root, int k, List<int> lstResult)
        {
            if (root == null)
                return;
            populateList(root.left, k, lstResult);
            lstResult.Add(root.val);
            populateList(root.right, k, lstResult);
        }
    }
}
