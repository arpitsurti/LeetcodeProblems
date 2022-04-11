using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*94. Binary Tree Inorder Traversal
     * Given the root of a binary tree, return the inorder traversal of its nodes' values.

        Example 1:
        Input: root = [1,null,2,3]
        Output: [1,3,2]

        Example 2:
        Input: root = []
        Output: []

        Example 3:
        Input: root = [1]
        Output: [1]
 
        Constraints:
        The number of nodes in the tree is in the range [0, 100].
        -100 <= Node.val <= 100
    */
    public class clsBinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> lstResult = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            TreeNode currNode = root;
            while (currNode != null || st.Count() != 0)
            {
                while (currNode != null)
                {
                    st.Push(currNode);
                    currNode = currNode.left;
                }
                currNode = st.Pop();
                lstResult.Add(currNode.val);
                currNode = currNode.right;
            }
            return lstResult;
        }

        public void inorderRecursive(TreeNode root, IList<int> lstResult)
        {
            if (root == null)
                return;
            inorderRecursive(root.left, lstResult);
            lstResult.Add(root.val);
            inorderRecursive(root.right, lstResult);
        }
    }
}
