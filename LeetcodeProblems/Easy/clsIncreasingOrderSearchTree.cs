using LeetcodeProblems.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*897. Increasing Order Search Tree
     * Given the root of a binary search tree, rearrange the tree in in-order so that the leftmost node in the tree is now the root of the tree, and every node has no left child and only one right child.

        Example 1:
        Input: root = [5,3,6,2,4,null,8,1,null,null,null,7,9]
        Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]

        Example 2:
        Input: root = [5,1,7]
        Output: [1,null,5,null,7]
 
        Constraints:
        The number of nodes in the given tree will be in the range [1, 100].
        0 <= Node.val <= 1000
    */
    public class clsIncreasingOrderSearchTree
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
                return null;
            Stack<TreeNode> st = new Stack<TreeNode>();
            TreeNode curr = root;

            TreeNode outputRoot = new TreeNode(0);
            TreeNode outputRootRight = outputRoot;

            while (curr != null || st.Count != 0)
            {
                while (curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }
                curr = st.Pop();
                outputRootRight.right = new TreeNode(curr.val);
                outputRootRight = outputRootRight.right;
                curr = curr.right;
            }
            return outputRoot.right;
        }
    }
}
