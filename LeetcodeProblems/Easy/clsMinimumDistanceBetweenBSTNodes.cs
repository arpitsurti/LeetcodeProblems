using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*783. Minimum Distance Between BST Nodes
     *** REF *** 
     * Given the root of a Binary Search Tree (BST), return the minimum difference between the values of any two different nodes in the tree.

        Example 1:
        Input: root = [4,2,6,1,3]
        Output: 1

        Example 2:
        Input: root = [1,0,48,null,null,12,49]
        Output: 1
 
        Constraints:
        The number of nodes in the tree is in the range [2, 100].
        0 <= Node.val <= 105
 
        Note: This question is the same as 530: https://leetcode.com/problems/minimum-absolute-difference-in-bst/
    */
    public class clsMinimumDistanceBetweenBSTNodes
    {
        /* RECURSIVE
         int output = int.MaxValue;
         int prev = -1;
         public int MinDiffInBST(TreeNode root) {
            if(root == null)
                return 0;
            MinDiffInBST(root.left);
            if(prev != -1)
                output = Math.Min(output, Math.Abs(prev - root.val));
            prev = root.val;
            MinDiffInBST(root.right);
            return output;
        }
        */
        public int MinDiffInBST(TreeNode root)
        {
            //ITERATIVE
            int output = int.MaxValue;
            Stack<TreeNode> st = new Stack<TreeNode>();
            int prev = -1;
            while (root != null || st.Count != 0)
            {
                while (root != null)
                {
                    st.Push(root);
                    root = root.left;
                }
                root = st.Pop();
                if (prev != -1)
                {
                    int currMin = Math.Abs(prev - root.val);
                    if (currMin < output)
                        output = currMin;
                }
                prev = root.val;
                root = root.right;
            }
            return output;
        }
    }
}
