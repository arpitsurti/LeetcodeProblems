using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*145. Binary Tree Postorder Traversal
     * Given the root of a binary tree, return the postorder traversal of its nodes' values.

        Example 1:
        Input: root = [1,null,2,3]
        Output: [3,2,1]

        Example 2:
        Input: root = []
        Output: []

        Example 3:
        Input: root = [1]
        Output: [1]
 
        Constraints:
        The number of the nodes in the tree is in the range [0, 100].
        -100 <= Node.val <= 100
 
        Follow up: Recursive solution is trivial, could you do it iteratively?
    */
    public class clsBinaryTreePostorderTraversal
    {
        /* RECURSIVE
         * IList<int> lstResult = new List<int>(); 
        public IList<int> PostorderTraversal(TreeNode root) {
            if(root == null)
                return lstResult;
            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            lstResult.Add(root.val);
            return lstResult;
        }
        */
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> lstResult = new List<int>();
            if (root == null)
                return lstResult;
            Stack<TreeNode> st = new Stack<TreeNode>();
            st.Push(root);
            while (st.Count != 0)
            {
                TreeNode curr = st.Pop();
                lstResult.Insert(0, curr.val);
                if (curr.left != null)
                    st.Push(curr.left);
                if (curr.right != null)
                    st.Push(curr.right);
            }
            return lstResult;
        }
    }
}
