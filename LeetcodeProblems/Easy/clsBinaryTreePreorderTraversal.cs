using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*144. Binary Tree Preorder Traversal
     *** REF ***
     * Given the root of a binary tree, return the preorder traversal of its nodes' values.

        Example 1:
        Input: root = [1,null,2,3]
        Output: [1,2,3]

        Example 2:
        Input: root = []
        Output: []

        Example 3:
        Input: root = [1]
        Output: [1]

        Constraints:
        The number of nodes in the tree is in the range [0, 100].
        -100 <= Node.val <= 100
 
        Follow up: Recursive solution is trivial, could you do it iteratively?
    */
    public class clsBinaryTreePreorderTraversal
    {
        /* USING RECURSION
        IList<int> lstResult = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root) {
            if(root == null)
                return lstResult;
            lstResult.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
            return lstResult;
        }
        */

        //USING ITERATION MOST IMPORTANT AS WE ARE USING STACK PUT RIGHT NODE FIRST
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> lstResult = new List<int>();
            if (root == null)
                return lstResult;
            Stack<TreeNode> st = new Stack<TreeNode>();
            st.Push(root);
            while (st.Count != 0)
            {
                TreeNode curr = st.Pop();
                lstResult.Add(curr.val);
                if (curr.right != null)
                    st.Push(curr.right);
                if (curr.left != null)
                    st.Push(curr.left);
            }
            return lstResult;
        }
    }
}
